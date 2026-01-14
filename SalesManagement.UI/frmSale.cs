using SalesManagement.BLL;
using SalesManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks; // Đảm bảo có using này
using System.Windows.Forms;

namespace SalesManagement.UI
{
    public partial class frmSale : Form
    {
        // === KHAI BÁO CÁC LỚP BLL CẦN THIẾT ===
        private readonly ProductBLL _productBLL = new ProductBLL();
        private readonly CustomerBLL _customerBLL = new CustomerBLL();
        private readonly InvoiceBLL _invoiceBLL = new InvoiceBLL();
        private List<InvoiceDetail> _currentInvoiceItems = new List<InvoiceDetail>();

        public frmSale()
        {
            InitializeComponent();
        }

        // === SỰ KIỆN LOAD CỦA FORM (ĐÃ SỬA LỖI) ===
        private async void frmSale_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                await LoadDataForComboBoxes();
                ResetForm();
            }
        }

        // === HÀM TẢI DỮ LIỆU MỚI, MẠNH MẼ HƠN ===
        private async Task LoadDataForComboBoxes()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (_customerBLL.GetAllCustomersFromCache() == null || !_customerBLL.GetAllCustomersFromCache().Any())
                {
                    await _customerBLL.LoadAllCustomersAsync();
                }
                cboCustomer.DataSource = _customerBLL.GetAllCustomersFromCache();
                cboCustomer.DisplayMember = "CustomerName";
                cboCustomer.ValueMember = "CustomerID";

                if (_productBLL.GetAllProductsFromCache() == null || !_productBLL.GetAllProductsFromCache().Any())
                {
                    await _productBLL.LoadAllProductsAsync();
                }
                cboProduct.DataSource = _productBLL.GetAllProductsFromCache();
                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu cho form bán hàng: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // === HÀM LÀM MỚI FORM ===
        private void ResetForm()
        {
            _currentInvoiceItems.Clear();
            RefreshDataGridView();
            if (cboCustomer.Items.Count > 0) cboCustomer.SelectedIndex = 0;
            if (cboProduct.Items.Count > 0) cboProduct.SelectedIndex = 0;
            numQuantity.Value = 1;
        }

        // === SỰ KIỆN CLICK NÚT "THÊM VÀO HÓA ĐƠN" ===
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = cboProduct.SelectedItem as Product;
            int quantity = (int)numQuantity.Value;
            if (selectedProduct == null || quantity <= 0) return;

            var existingItem = _currentInvoiceItems.FirstOrDefault(item => item.ProductID == selectedProduct.ProductID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _currentInvoiceItems.Add(new InvoiceDetail
                {
                    ProductID = selectedProduct.ProductID,
                    Quantity = quantity,
                    UnitPrice = selectedProduct.Price
                });
            }
            RefreshDataGridView();
        }

        // === HÀM LÀM MỚI DATAGRIDVIEW VÀ TÍNH TỔNG TIỀN ===
        private void RefreshDataGridView()
        {
            dgvInvoiceItems.DataSource = null;
            if (_currentInvoiceItems.Any())
            {
                dgvInvoiceItems.DataSource = _currentInvoiceItems.Select(d => new
                {
                    TenSanPham = _productBLL.GetAllProductsFromCache().First(p => p.ProductID == d.ProductID).ProductName,
                    SoLuong = d.Quantity,
                    DonGia = d.UnitPrice,
                    ThanhTien = d.Quantity * d.UnitPrice
                }).ToList();
            }
            lblTotalAmount.Text = _currentInvoiceItems.Sum(d => d.Quantity * d.UnitPrice).ToString("N0") + " VNĐ";
        }

        // === SỰ KIỆN CLICK NÚT "TẠO HÓA ĐƠN" ===
        private async void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (!_currentInvoiceItems.Any())
            {
                MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var invoice = new Invoice { CustomerID = (int)cboCustomer.SelectedValue, InvoiceDate = DateTime.Now };

            try
            {
                this.Cursor = Cursors.WaitCursor;
                // Thêm .ConfigureAwait(false) vào đây
                await _invoiceBLL.CreateInvoiceAsync(invoice, _currentInvoiceItems).ConfigureAwait(false);

                MessageBox.Show("Tạo hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Thêm .ConfigureAwait(false) vào đây
                await _productBLL.LoadAllProductsAsync().ConfigureAwait(false);
                // Thêm .ConfigureAwait(false) vào đây
                await LoadDataForComboBoxes().ConfigureAwait(false);

                // ResetForm() là hàm sync nên không cần
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // === SỰ KIỆN CLICK NÚT "HỦY" ===
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
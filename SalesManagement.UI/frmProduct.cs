using System;
using SalesManagement.BLL;
using SalesManagement.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagement.UI
{
    public partial class frmProduct : Form
    {
        private readonly ProductBLL _productBLL = new ProductBLL();

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                RefreshDataGridView();
                SetButtonState(false);
            }
        }

        private void RefreshDataGridView(object dataSource = null)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = dataSource ?? _productBLL.GetAllProductsFromCache();
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgvProducts.Columns["ProductID"].HeaderText = "Mã SP";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên Sản phẩm";
            dgvProducts.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducts.Columns["Price"].HeaderText = "Đơn giá";
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvProducts.Columns["Stock"].HeaderText = "Tồn kho";
        }

        private void SetButtonState(bool enabled)
        {
            btnUpdate.Enabled = enabled;
            btnDelete.Enabled = enabled;
        }

        private void ClearControls()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtSearch.Clear();
            dgvProducts.ClearSelection();
            SetButtonState(false);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                SetButtonState(true);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                await _productBLL.AddProductAsync(product);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearControls();
            }
            catch (FormatException) { MessageBox.Show("Đơn giá hoặc tồn kho phải là số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text)) { MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                var product = new Product
                {
                    ProductID = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };
                await _productBLL.UpdateProductAsync(product);
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }
            catch (FormatException) { MessageBox.Show("Đơn giá hoặc tồn kho phải là số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text)) { MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int productId = int.Parse(txtProductId.Text);
                    await _productBLL.DeleteProductAsync(productId);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearControls();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            RefreshDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView(_productBLL.SearchProductsLocal(txtSearch.Text));
        }
    }
}
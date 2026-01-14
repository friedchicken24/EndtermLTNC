using SalesManagement.BLL;
using SalesManagement.Entity;
using System;
using System.Windows.Forms;

namespace SalesManagement.UI
{
    public partial class frmCustomer : Form
    {
        private readonly CustomerBLL _customerBLL = new CustomerBLL();

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                RefreshDataGridView();
                SetButtonState(false);
            }
        }

        private void RefreshDataGridView(object dataSource = null)
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = dataSource ?? _customerBLL.GetAllCustomersFromCache();
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgvCustomers.Columns["CustomerID"].HeaderText = "Mã KH";
            dgvCustomers.Columns["CustomerName"].HeaderText = "Tên Khách hàng";
            dgvCustomers.Columns["CustomerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomers.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgvCustomers.Columns["Address"].HeaderText = "Địa chỉ";
        }

        private void SetButtonState(bool enabled)
        {
            btnUpdateCustomer.Enabled = enabled;
            btnDeleteCustomer.Enabled = enabled;
        }

        private void ClearControls()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtSearchCustomer.Clear();
            dgvCustomers.ClearSelection();
            SetButtonState(false);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                SetButtonState(true);
            }
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    CustomerName = txtCustomerName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text
                };
                await _customerBLL.AddCustomerAsync(customer);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                ClearControls();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text)) { MessageBox.Show("Vui lòng chọn một khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                var customer = new Customer
                {
                    CustomerID = int.Parse(txtCustomerId.Text),
                    CustomerName = txtCustomerName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text
                };
                await _customerBLL.UpdateCustomerAsync(customer);
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text)) { MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int customerId = int.Parse(txtCustomerId.Text);
                    await _customerBLL.DeleteCustomerAsync(customerId);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                    ClearControls();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            ClearControls();
            RefreshDataGridView();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView(_customerBLL.SearchCustomersLocal(txtSearchCustomer.Text));
        }

        private void txtSearchCustomer_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
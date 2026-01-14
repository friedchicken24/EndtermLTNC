using SalesManagement.BLL;
using SalesManagement.Entity;
using System;
using System.Windows.Forms;

namespace SalesManagement.UI
{
    public partial class frmMain : Form
    {
        private readonly User _currentUser;
        private readonly ProductBLL _productBLL = new ProductBLL();
        private readonly CustomerBLL _customerBLL = new CustomerBLL();

        public frmMain(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.IsMdiContainer = true;
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            // Áp dụng quy tắc chống sập form
            if (!this.DesignMode)
            {
                this.Text = $"Quản lý Bán hàng - Chào {_currentUser.Username}";
                PhanQuyen();

                try
                {
                    
                    await _productBLL.LoadAllProductsAsync();
                    await _customerBLL.LoadAllCustomersAsync();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nghiêm trọng khi tải dữ liệu: " + ex.Message, "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
        }

        private void PhanQuyen()
        {
            báoCáoDoanhThuToolStripMenuItem.Visible = _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmProduct());
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmCustomer());
        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmSale());
        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e) => OpenChildForm(new frmReport());

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new frmLogin();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
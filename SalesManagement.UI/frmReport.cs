using SalesManagement.BLL;
using System;
using System.Windows.Forms;

namespace SalesManagement.UI
{
    public partial class frmReport : Form
    {
        private readonly ReportBLL _reportBLL = new ReportBLL();

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                dtpEndDate.Value = DateTime.Now;
                dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnGenerate.Enabled = false;

                var reportData = await _reportBLL.GetRevenueReportAsync(dtpStartDate.Value, dtpEndDate.Value);
                dgvReport.DataSource = reportData;
                FormatDataGridView();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                this.Cursor = Cursors.Default;
                btnGenerate.Enabled = true;
            }
        }

        private void FormatDataGridView()
        {
            if (dgvReport.DataSource != null && dgvReport.Columns.Count > 0)
            {
                dgvReport.Columns["Date"].HeaderText = "Ngày";
                dgvReport.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReport.Columns["Date"].Width = 150;

                dgvReport.Columns["TotalRevenue"].HeaderText = "Tổng Doanh thu (VNĐ)";
                dgvReport.Columns["TotalRevenue"].DefaultCellStyle.Format = "N0";
                dgvReport.Columns["TotalRevenue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
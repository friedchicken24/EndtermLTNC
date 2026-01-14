using System;
using System.Configuration;
using System.Windows.Forms;

namespace SalesManagement.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Đọc trực tiếp chuỗi kết nối từ file App.config
                string connStr = ConfigurationManager.ConnectionStrings["MySqlSalesDb"].ConnectionString;

                if (string.IsNullOrEmpty(connStr))
                {
                    MessageBox.Show("KHÔNG TÌM THẤY CHUỖI KẾT NỐI 'MySqlSalesDb'!\n\nVui lòng kiểm tra lại file App.config.", "Lỗi Cấu hình");
                    return;
                }

                MessageBox.Show("Chuỗi kết nối MySQL đang được sử dụng là:\n\n" + connStr, "Kiểm tra App.config");

                // Chạy ứng dụng bình thường
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi đọc App.config: " + ex.Message);
            }
        }
    }
}
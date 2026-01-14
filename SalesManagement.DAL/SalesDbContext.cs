using Microsoft.EntityFrameworkCore;
using SalesManagement.Entity;
using System.Configuration;

namespace SalesManagement.DAL
{
    public class SalesDbContext : DbContext
    {
        // ... (Danh sách các DbSet<T> của bạn)
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. Đọc chuỗi kết nối mới có tên là "MySqlSalesDb"
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlSalesDb"].ConnectionString;

            // 2. Sử dụng UseMySql thay vì UseSqlServer
            // ServerVersion.AutoDetect sẽ tự động phát hiện phiên bản MySQL bạn đang dùng
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
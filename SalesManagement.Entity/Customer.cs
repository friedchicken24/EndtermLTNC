using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagement.Entity
{
    [Table("tblCustomer")]
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; } // Đã thêm ?
        public string? PhoneNumber { get; set; }  // Đã thêm ?
        public string? Address { get; set; }      // Đã thêm ?
    }
}
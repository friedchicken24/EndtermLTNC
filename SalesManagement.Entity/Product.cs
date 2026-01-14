using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagement.Entity
{
    [Table("tblProduct")]
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; } // Đã thêm ?
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
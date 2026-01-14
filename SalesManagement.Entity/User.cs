using System.ComponentModel.DataAnnotations.Schema;
namespace SalesManagement.Entity
{
    [Table("tblUser")]
    public class User

    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
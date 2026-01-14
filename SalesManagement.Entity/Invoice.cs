using System;
using System.ComponentModel.DataAnnotations.Schema; // <-- Dòng này phải có

namespace SalesManagement.Entity
{
    [Table("tblInvoice")] // <-- THÊM/ĐẢM BẢO CÓ DÒNG NÀY
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using SalesManagement.DAL; // Cần thiết để sử dụng SalesDbContext
using SalesManagement.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    public class InvoiceBLL
    {
      
        public async Task CreateInvoiceAsync(Invoice invoice, List<InvoiceDetail> details)
        {
           
            using (var context = new SalesDbContext())
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                
                    context.Invoices.Add(invoice);
                    await context.SaveChangesAsync(); // Lưu để lấy InvoiceID

                    decimal totalAmount = 0;

                    
                    foreach (var detail in details)
                    {
                      
                        detail.InvoiceID = invoice.InvoiceID;
                        context.InvoiceDetails.Add(detail);

                      
                        var product = await context.Products.FindAsync(detail.ProductID).ConfigureAwait(false);

                        if (product == null)
                        {
                            throw new Exception($"Sản phẩm với ID {detail.ProductID} không tồn tại.");
                        }
                        if (product.Stock < detail.Quantity)
                        {
                            throw new Exception($"Sản phẩm '{product.ProductName}' không đủ hàng tồn kho (Chỉ còn {product.Stock}).");
                        }

                        product.Stock -= detail.Quantity; 
                        context.Products.Update(product); 

                        // Tính tổng tiền
                        totalAmount += detail.Quantity * detail.UnitPrice;
                    }

                    invoice.TotalAmount = totalAmount;
                    context.Invoices.Update(invoice);
                    await context.SaveChangesAsync().ConfigureAwait(false);

                   
                    await transaction.CommitAsync().ConfigureAwait(false);
                }
                catch (Exception)
                {
                   
                    await transaction.RollbackAsync();
                    throw; 
                }
            }
        }
    }
}
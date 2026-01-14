using Microsoft.EntityFrameworkCore;
using SalesManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    public class ReportBLL
    {
        
        public class RevenueReportItem
        {
            public DateTime Date { get; set; }
            public decimal TotalRevenue { get; set; }
        }

        /// <summary>
        /// Lấy dữ liệu báo cáo doanh thu theo ngày trong một khoảng thời gian.
        /// </summary>
        /// <param name="startDate">Ngày bắt đầu</param>
        /// <param name="endDate">Ngày kết thúc</param>
        /// <returns>Danh sách các mục doanh thu đã được tổng hợp theo ngày.</returns>
        public async Task<List<RevenueReportItem>> GetRevenueReportAsync(DateTime startDate, DateTime endDate)
        {
            using (var context = new SalesDbContext())
            {
                
                var query = context.Invoices
                  
                    .Where(inv => inv.InvoiceDate.Date >= startDate.Date && inv.InvoiceDate.Date <= endDate.Date)

                   
                    .GroupBy(inv => inv.InvoiceDate.Date)

                    .Select(group => new RevenueReportItem
                    {
                        // Lấy Key (ngày) của nhóm gán cho Date
                        Date = group.Key,
                        // Tính tổng cột TotalAmount của tất cả các hóa đơn trong nhóm
                        TotalRevenue = group.Sum(inv => inv.TotalAmount)
                    })

                    // 4. Sắp xếp kết quả theo thứ tự ngày tăng dần.
                    .OrderBy(reportItem => reportItem.Date);

                // 5. Thực thi truy vấn một cách bất đồng bộ và trả về kết quả dưới dạng List.
                return await query.ToListAsync();
            }
        }
    }
}
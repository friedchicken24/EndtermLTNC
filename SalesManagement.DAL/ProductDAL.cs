using Microsoft.EntityFrameworkCore;
using SalesManagement.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesManagement.DAL
{
    public class ProductDAL
    {
        public async Task<List<Product?>> GetAllAsync()
        {
            using (var context = new SalesDbContext())
            {
                return await context.Products.ToListAsync().ConfigureAwait(false);
            }
        }

        public async Task AddAsync(Product product)
        {
            using (var context = new SalesDbContext())
            {
                await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Product product)
        {
            using (var context = new SalesDbContext())
            {
                context.Products.Update(product);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int productId)
        {
            using (var context = new SalesDbContext())
            {
                var product = await context.Products.FindAsync(productId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SalesManagement.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesManagement.DAL
{
    public class CustomerDAL
    {
        public async Task<List<Customer?>> GetAllAsync()
        {
            using (var context = new SalesDbContext())
            {
                return await context.Customers.ToListAsync().ConfigureAwait(false);
            }
        }

        public async Task AddAsync(Customer customer)
        {
            using (var context = new SalesDbContext())
            {
                await context.Customers.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Customer customer)
        {
            using (var context = new SalesDbContext())
            {
                context.Customers.Update(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int customerId)
        {
            using (var context = new SalesDbContext())
            {
                var customer = await context.Customers.FindAsync(customerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
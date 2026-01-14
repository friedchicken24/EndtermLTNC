using SalesManagement.DAL;
using SalesManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAL _customerDAL = new CustomerDAL();
        // Khởi tạo ngay để đảm bảo cache không bao giờ null
        private List<Customer> _allCustomersCache = new List<Customer>();

        public async Task LoadAllCustomersAsync()
        {
            _allCustomersCache = await _customerDAL.GetAllAsync().ConfigureAwait(false);
        }

        public List<Customer> GetAllCustomersFromCache() => _allCustomersCache;

        public List<Customer> SearchCustomersLocal(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return _allCustomersCache;
            string lowerKeyword = keyword.ToLower();
            return _allCustomersCache.Where(c => (c.CustomerName != null && c.CustomerName.ToLower().Contains(lowerKeyword)) || (c.PhoneNumber != null && c.PhoneNumber.Contains(keyword))).ToList();
        }

        // --- LUỒNG XỬ LÝ THÊM ---
        public async Task AddCustomerAsync(Customer customer)
        {
            if (customer == null || string.IsNullOrWhiteSpace(customer.CustomerName))
            {
                throw new Exception("Tên khách hàng không được để trống.");
            }
            await _customerDAL.AddAsync(customer);
            _allCustomersCache.Add(customer);
        }

        // --- LUỒNG XỬ LÝ SỬA ---
        public async Task UpdateCustomerAsync(Customer customer)
        {
            if (customer == null || customer.CustomerID <= 0)
            {
                throw new Exception("Khách hàng không hợp lệ để cập nhật.");
            }
            await _customerDAL.UpdateAsync(customer);
            var customerInCache = _allCustomersCache.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (customerInCache != null)
            {
                customerInCache.CustomerName = customer.CustomerName;
                customerInCache.PhoneNumber = customer.PhoneNumber;
                customerInCache.Address = customer.Address;
            }
        }

        // --- LUỒNG XỬ LÝ XÓA ---
        public async Task DeleteCustomerAsync(int customerId)
        {
            if (customerId <= 0)
            {
                throw new Exception("Mã khách hàng không hợp lệ.");
            }
            await _customerDAL.DeleteAsync(customerId);
            var customerToRemove = _allCustomersCache.FirstOrDefault(c => c.CustomerID == customerId);
            if (customerToRemove != null)
            {
                _allCustomersCache.Remove(customerToRemove);
            }
        }
    }
}
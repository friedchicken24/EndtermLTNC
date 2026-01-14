using SalesManagement.DAL;
using SalesManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL _productDAL = new ProductDAL();
        // Khởi tạo ngay để đảm bảo cache không bao giờ null
        private List<Product> _allProductsCache = new List<Product>();

        // Tải toàn bộ sản phẩm từ DB vào cache
        public async Task LoadAllProductsAsync()
        {
            _allProductsCache = await _productDAL.GetAllAsync().ConfigureAwait(false);
        }


        public List<Product> GetAllProductsFromCache() => _allProductsCache;


        public List<Product> SearchProductsLocal(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return _allProductsCache;
            string lowerKeyword = keyword.ToLower();
            return _allProductsCache.Where(p => p.ProductName != null && p.ProductName.ToLower().Contains(lowerKeyword)).ToList();
        }

        // --- LUỒNG XỬ LÝ THÊM ---
        public async Task AddProductAsync(Product product)
        {
            // 1. Kiểm tra nghiệp vụ
            if (product == null || string.IsNullOrWhiteSpace(product.ProductName) || product.Price <= 0 || product.Stock < 0)
            {
                throw new Exception("Thông tin sản phẩm không hợp lệ.");
            }
            // 2. Gọi xuống DAL để lưu vào CSDL
            await _productDAL.AddAsync(product);

            // 3. Cập nhật lại cache trên RAM
            _allProductsCache.Add(product);
        }

        // --- LUỒNG XỬ LÝ SỬA ---
        public async Task UpdateProductAsync(Product product)
        {
            // 1. Kiểm tra nghiệp vụ
            if (product == null || product.ProductID <= 0)
            {
                throw new Exception("Sản phẩm không hợp lệ để cập nhật.");
            }
            // 2. Gọi xuống DAL để cập nhật trong CSDL
            await _productDAL.UpdateAsync(product);

            // 3. Cập nhật lại đối tượng tương ứng trong cache trên RAM
            var productInCache = _allProductsCache.FirstOrDefault(p => p.ProductID == product.ProductID);
            if (productInCache != null)
            {
                productInCache.ProductName = product.ProductName;
                productInCache.Price = product.Price;
                productInCache.Stock = product.Stock;
            }
        }

        // --- LUỒNG XỬ LÝ XÓA ---
        public async Task DeleteProductAsync(int productId)
        {
            // 1. Kiểm tra nghiệp vụ
            if (productId <= 0)
            {
                throw new Exception("Mã sản phẩm không hợp lệ.");
            }
            // 2. Gọi xuống DAL để xóa trong CSDL
            await _productDAL.DeleteAsync(productId);

            // 3. Xóa đối tượng tương ứng khỏi cache trên RAM
            var productToRemove = _allProductsCache.FirstOrDefault(p => p.ProductID == productId);
            if (productToRemove != null)
            {
                _allProductsCache.Remove(productToRemove);
            }
        }
    }
}
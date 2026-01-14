using SalesManagement.DAL;
using SalesManagement.Entity;
using System.Threading.Tasks;

namespace SalesManagement.BLL
{
    /// <summary>
    /// Lớp Business Logic Layer cho đối tượng User.
    /// Chịu trách nhiệm xử lý các logic nghiệp vụ liên quan đến người dùng,
    /// ví dụ như kiểm tra thông tin đăng nhập.
    /// </summary>
    public class UserBLL
    {
        // Khởi tạo một đối tượng của lớp DAL tương ứng để truy cập CSDL.
        // Đây là cách BLL "nói chuyện" với DAL.
        private readonly UserDAL _userDAL = new UserDAL();

        /// <summary>
        /// Xử lý logic đăng nhập.
        /// </summary>
        /// <param name="username">Tên đăng nhập do người dùng nhập</param>
        /// <param name="password">Mật khẩu do người dùng nhập</param>
        /// <returns>
        /// Trả về một đối tượng User nếu đăng nhập thành công.
        /// Trả về null nếu tên đăng nhập hoặc mật khẩu không đúng, hoặc đầu vào không hợp lệ.
        /// </returns>
        public async Task<User> LoginAsync(string username, string password)
        {
            // Bước 1: Kiểm tra nghiệp vụ cơ bản (Validation)
            // Tên đăng nhập và mật khẩu không được để trống.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null; // Trả về null nếu không hợp lệ
            }

            // Bước 2: Gọi xuống lớp DAL để thực hiện truy vấn CSDL
            // BLL không trực tiếp truy vấn CSDL, nó "nhờ" DAL làm việc đó.
            return await _userDAL.GetUserAsync(username, password);
        }
    }
}
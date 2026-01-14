Ứng dụng Quản lý Bán hàng (Sales Management App)
![alt text](https://img.shields.io/badge/WinForms-C%23-blueviolet)
![alt text](https://img.shields.io/badge/.NET-Framework-blue)
![alt text](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoft-sql-server&logoColor=white)
![alt text](https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=white)
Đây là đồ án môn học xây dựng ứng dụng desktop Quản lý Bán hàng bằng C# WinForms, tuân thủ kiến trúc 3 lớp và áp dụng các kỹ thuật lập trình hiện đại.
📜 Mục lục
Giới thiệu
Tính năng chính
Kiến trúc & Công nghệ
Hướng dẫn Cài đặt & Chạy thử
Hình ảnh Demo
Tác giả
🌟 Giới thiệu
Ứng dụng được xây dựng nhằm mô phỏng một hệ thống quản lý bán hàng cơ bản cho một cửa hàng nhỏ, giúp nhân viên thực hiện các tác vụ hàng ngày một cách hiệu quả và chính xác, bao gồm:
Quản lý thông tin sản phẩm và tồn kho.
Quản lý thông tin khách hàng.
Lập hóa đơn bán hàng nhanh chóng.
Thống kê doanh thu theo thời gian.
✨ Tính năng chính
Chức năng Bắt buộc
Quản lý Sản phẩm: CRUD (Thêm, Sửa, Xóa, Tìm kiếm) thông tin sản phẩm, quản lý số lượng tồn kho.
Quản lý Khách hàng: CRUD (Thêm, Sửa, Xóa, Tìm kiếm) thông tin khách hàng.
Lập Hóa đơn: Thực hiện nghiệp vụ bán hàng, tự động cập nhật tồn kho.
Báo cáo Thống kê: Xem báo cáo doanh thu theo ngày/tháng/năm tùy chọn.
Xử lý Giao dịch (Transaction): Đảm bảo tính toàn vẹn dữ liệu. Nếu việc tạo hóa đơn thất bại, số lượng tồn kho sẽ không bị ảnh hưởng.
Chức năng Mở rộng
Đăng nhập: Xác thực người dùng trước khi vào hệ thống.
Phân quyền: Giới hạn chức năng dựa trên vai trò người dùng (Admin vs. Employee). Ví dụ: chỉ Admin mới có quyền xem báo cáo.
🏗️ Kiến trúc & Công nghệ
1. Kiến trúc
Dự án được xây dựng theo Kiến trúc 3 lớp (3-Tier Architecture) và được tách thành các Component (Project) riêng biệt để đảm bảo tính module hóa, dễ bảo trì và mở rộng.
SalesManagement.UI (Presentation Layer): Lớp giao diện người dùng (Windows Forms), chịu trách nhiệm hiển thị và nhận tương tác.
SalesManagement.BLL (Business Logic Layer): Lớp nghiệp vụ, chứa toàn bộ logic xử lý, kiểm tra dữ liệu và các quy tắc kinh doanh.
SalesManagement.DAL (Data Access Layer): Lớp truy cập dữ liệu, là lớp duy nhất giao tiếp với CSDL thông qua Entity Framework.
SalesManagement.Entity: Chứa các lớp đối tượng (POCO) ánh xạ với các bảng trong CSDL.
2. Công nghệ
Ngôn ngữ: C#
Nền tảng: .NET
Giao diện: Windows Forms (WinForms)
CSDL: SQL Server (LocalDB) / MySQL (XAMPP)
ORM: Entity Framework Core
Kỹ thuật nâng cao:
Lập trình Bất đồng bộ (async/await): Giúp ứng dụng luôn phản hồi, không bị "đơ" khi thực hiện các tác vụ nặng.
Tối ưu tìm kiếm (Client-side Cache): Dữ liệu được tải một lần và tìm kiếm trên RAM để tăng tốc độ phản hồi.
Dependency Injection (Manual): Các lớp phụ thuộc được khởi tạo và truyền vào một cách thủ công, tạo nền tảng cho việc áp dụng DI Container trong tương lai.

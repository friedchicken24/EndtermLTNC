-- ===================================================================
-- SCRIPT TẤT CẢ TRONG MỘT: TẠO CSDL, TÀI KHOẢN, BẢNG & DỮ LIỆU
-- Dành cho SQL Server (LocalDB)
-- ===================================================================

-- BƯỚC A: DỌN DẸP MÔI TRƯỜNG CŨ VÀ TẠO MÔI TRƯỜNG MỚI
USE master;
GO

-- Xóa CSDL cũ nếu tồn tại để làm lại từ đầu
-- Lệnh này đảm bảo script có thể chạy lại nhiều lần mà không bị lỗi
IF DB_ID('SalesDB') IS NOT NULL
BEGIN
    ALTER DATABASE SalesDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SalesDB;
    PRINT 'Da xoa CSDL SalesDB cu.';
END
GO

-- Xóa tài khoản đăng nhập cũ nếu tồn tại
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'salesuser')
BEGIN
    DROP LOGIN salesuser;
    PRINT 'Da xoa tai khoan dang nhap salesuser cu.';
END
GO

-- Tạo CSDL mới
CREATE DATABASE SalesDB;
GO
PRINT 'Da tao CSDL SalesDB moi.';

-- Tạo tài khoản đăng nhập mới trên Server
CREATE LOGIN salesuser WITH PASSWORD = '123456';
GO
PRINT 'Da tao tai khoan dang nhap salesuser moi.';

-- ===================================================================
-- BƯỚC B: CẤU HÌNH CSDL VÀ TẠO CẤU TRÚC BẢNG
-- ===================================================================

-- Chuyển sang làm việc với CSDL SalesDB
USE SalesDB;
GO

-- Tạo một User trong CSDL SalesDB và liên kết nó với tài khoản Login vừa tạo
CREATE USER salesuser FOR LOGIN salesuser;
GO
PRINT 'Da tao user trong CSDL SalesDB va lien ket voi tai khoan dang nhap.';

-- Cấp cho user này quyền cao nhất (db_owner) trên CSDL SalesDB
-- Điều này đảm bảo user có toàn quyền đọc, ghi, sửa, xóa dữ liệu
ALTER ROLE db_owner ADD MEMBER salesuser;
GO
PRINT 'Da cap toan quyen cho user salesuser tren CSDL SalesDB.';

-- Tạo các bảng
PRINT 'Bat dau tao cac bang...';
CREATE TABLE tblUser (
    UserID INT IDENTITY(1,1) PRIMARY KEY, -- IDENTITY(1,1) là tự tăng
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

CREATE TABLE tblCustomer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(500)
);

CREATE TABLE tblProduct (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Stock INT NOT NULL
);

CREATE TABLE tblInvoice (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT FOREIGN KEY REFERENCES tblCustomer(CustomerID),
    InvoiceDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL
);

CREATE TABLE tblInvoiceDetail (
    InvoiceDetailID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT FOREIGN KEY REFERENCES tblInvoice(InvoiceID),
    ProductID INT FOREIGN KEY REFERENCES tblProduct(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL
);
PRINT 'Da tao xong cac bang.';

-- ===================================================================
-- BƯỚC C: CHÈN DỮ LIỆU MẪU (SEED DATA)
-- ===================================================================
PRINT 'Bat dau chen du lieu mau...';

-- Thêm tài khoản để đăng nhập
INSERT INTO tblUser (Username, Password, Role) VALUES 
('admin', '123', 'Admin'),
('nhanvien', '123', 'Employee');

-- Thêm khách hàng mẫu (Chữ N' phía trước để hỗ trợ tiếng Việt)
INSERT INTO tblCustomer (CustomerName, PhoneNumber, Address) VALUES
(N'Nguyễn Văn An', '0987654321', N'123 Giải Phóng, Hà Nội'),
(N'Trần Thị Bình', '0123456789', N'456 Lê Lợi, TP. Hồ Chí Minh'),
(N'Khách vãng lai', '', '');

-- Thêm sản phẩm mẫu
INSERT INTO tblProduct (ProductName, Price, Stock) VALUES
(N'Bàn phím cơ DareU', 850000, 50),
(N'Chuột không dây Logitech M331', 350000, 120),
(N'Màn hình Dell UltraSharp 24 inch', 4500000, 30),
(N'Tai nghe Sony WH-1000XM4', 6990000, 15);

PRINT 'Da chen xong du lieu mau.';
GO

PRINT 'HOAN TAT! Da tao CSDL, tai khoan, bang va du lieu mau thanh cong.';
GO
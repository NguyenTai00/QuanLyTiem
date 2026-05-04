CREATE TABLE NhanVien (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10), -- Nam hoặc Nữ
    DienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    DiaChi NVARCHAR(200),
    NgayVaoLam DATE DEFAULT GETDATE(),
    MoTa NVARCHAR(500)
);
GO
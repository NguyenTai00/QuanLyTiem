USE QuanLyTiem
GO

-- 1. Xóa các tài khoản không phải Admin để tránh trùng lặp dữ liệu NULL
DELETE FROM Account WHERE UserName <> N'Admin';
GO

-- 2. Đảm bảo bảng NhanVien đã có nhân viên số 1
IF NOT EXISTS (SELECT * FROM NhanVien WHERE ID = 1)
BEGIN
    SET IDENTITY_INSERT NhanVien ON;
    INSERT INTO NhanVien (ID, HoTen, NgayVaoLam) VALUES (1, N'Quản trị viên', GETDATE());
    SET IDENTITY_INSERT NhanVien OFF;
END
GO

-- 3. Gán tài khoản Admin nối với nhân viên 1
UPDATE Account SET IDNhanVien = 1 WHERE UserName = N'Admin';
GO

-- 4. BÂY GIỜ TẠO CÁC MŨI TÊN KẾT NỐI (Khóa ngoại)
-- Nối Account -> NhanVien (Quan hệ 1-1)
ALTER TABLE Account ADD CONSTRAINT UC_Account_Employee UNIQUE (IDNhanVien);
ALTER TABLE Account ADD CONSTRAINT FK_Account_NhanVien FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);

-- 5. Sửa bảng PhieuNhap để nối sang NhanVien (Thay vì nối sang Account như trước)
-- Xóa cột cũ nếu còn
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuNhap') AND name = 'NguoiNhap')
    ALTER TABLE PhieuNhap DROP COLUMN NguoiNhap;
GO
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuNhap') AND name = 'IDNhanVien')
    ALTER TABLE PhieuNhap DROP COLUMN IDNhanVien;
GO

-- Thêm cột IDNhanVien chuẩn kiểu số vào PhieuNhap và nối dây
ALTER TABLE PhieuNhap ADD IDNhanVien INT NOT NULL;
ALTER TABLE PhieuNhap ADD CONSTRAINT FK_PhieuNhap_NhanVien FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);
GO
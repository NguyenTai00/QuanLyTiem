USE QuanLyTiem
GO

-- 1. Đảm bảo bảng NhanVien đã có nhân viên số 2 (cho Thúy)
IF NOT EXISTS (SELECT * FROM NhanVien WHERE ID = 2)
BEGIN
    SET IDENTITY_INSERT NhanVien ON;
    INSERT INTO NhanVien (ID, HoTen, NgayVaoLam) VALUES (2, N'Nguyễn Thị Thúy', GETDATE());
    SET IDENTITY_INSERT NhanVien OFF;
END
GO

-- 2. Sửa lại tài khoản: 
-- Đổi UserName thành 'thuy' cho dễ gõ
-- Gán IDNhanVien = 2 để không bị lỗi NULL
UPDATE Account 
SET UserName = N'thuy', 
    IDNhanVien = 2 
WHERE DisplayName = N'Thuy';
GO
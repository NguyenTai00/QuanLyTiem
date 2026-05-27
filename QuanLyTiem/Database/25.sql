USE QuanLyTiem
GO

-- 1. Thêm cột IDNhanVien vào bảng Account để biết tài khoản này của ai
ALTER TABLE Account ADD IDNhanVien INT;
GO

-- 2. Tạo khóa ngoại nối Account(IDNhanVien) sang NhanVien(ID)
ALTER TABLE Account ADD CONSTRAINT FK_Account_NhanVien 
FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);
GO

-- 3. Cập nhật thử: Gán tài khoản 'Admin' cho nhân viên có ID = 1
-- (Bạn hãy kiểm tra xem trong bảng NhanVien đã có dữ liệu chưa nhé)
UPDATE Account SET IDNhanVien = 1 WHERE UserName = N'Admin';
GO

ALTER PROC USP_Login
    @userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
    SELECT a.UserName, n.HoTen as DisplayName, a.PassWord, a.Type, a.IDNhanVien
    FROM Account a
    LEFT JOIN NhanVien n ON a.IDNhanVien = n.ID
    WHERE a.UserName = @userName AND a.PassWord = @passWord
END
GO
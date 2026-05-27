USE QuanLyTiem
GO

-- 1. Xóa khóa ngoại trước (Cắt sợi dây liên kết để giải phóng cột)
IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_PhieuNhap_NV')
BEGIN
    ALTER TABLE PhieuNhap DROP CONSTRAINT FK_PhieuNhap_NV;
END
GO

-- 2. Bây giờ mới xóa cột IDNhanVien (kiểu số)
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuNhap') AND name = 'IDNhanVien')
BEGIN
    ALTER TABLE PhieuNhap DROP COLUMN IDNhanVien;
END
GO

-- 3. Thêm cột NguoiNhap (kiểu chữ) nếu nó chưa tồn tại
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuNhap') AND name = 'NguoiNhap')
BEGIN
    ALTER TABLE PhieuNhap ADD NguoiNhap NVARCHAR(100);
END
GO

-- Kiểm tra lại cấu trúc bảng một lần nữa
sp_help PhieuNhap
USE QuanLyTiem
GO

-- 1. Procedure lưu Phiếu nhập và trả về ID vừa tạo
CREATE OR ALTER PROC USP_InsertPhieuNhap
    @idNCC INT, @idNV INT
AS
BEGIN
    INSERT INTO PhieuNhap (IDNhaCungCap, IDNhanVien, NgayNhap, TongTien) 
    VALUES (@idNCC, @idNV, GETDATE(), 0)
    
    SELECT SCOPE_IDENTITY() -- Trả về ID vừa tạo
END
GO

-- 2. Procedure lưu chi tiết và tự động cộng kho
CREATE OR ALTER PROC USP_InsertChiTietPhieu
    @idPhieu INT, @idNL INT, @sl FLOAT, @gia FLOAT
AS
BEGIN
    -- Lưu chi tiết
    INSERT INTO ChiTietPhieuNhap (IDPhieuNhap, IDNguyenLieu, SoLuong, GiaNhap)
    VALUES (@idPhieu, @idNL, @sl, @gia)

    -- Cộng vào kho nguyên liệu
    UPDATE NguyenLieu SET SoLuongTon = SoLuongTon + @sl WHERE ID = @idNL
END
GO
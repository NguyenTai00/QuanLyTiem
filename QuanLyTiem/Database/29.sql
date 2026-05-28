USE QuanLyTiem
GO

CREATE OR ALTER PROC USP_UpdateChiTietPhieu
    @idPhieu INT, @idNL INT, @newSL FLOAT, @newGia FLOAT
AS
BEGIN
    -- 1. Lấy số lượng cũ để tính độ chênh lệch
    DECLARE @oldSL FLOAT = (SELECT SoLuong FROM ChiTietPhieuNhap WHERE IDPhieuNhap = @idPhieu AND IDNguyenLieu = @idNL)
    DECLARE @diff FLOAT = @newSL - @oldSL

    -- 2. Cập nhật lại kho nguyên liệu (Cộng thêm phần chênh lệch)
    UPDATE NguyenLieu SET SoLuongTon = SoLuongTon + @diff WHERE ID = @idNL

    -- 3. Cập nhật lại dòng chi tiết phiếu
    UPDATE ChiTietPhieuNhap SET SoLuong = @newSL, GiaNhap = @newGia 
    WHERE IDPhieuNhap = @idPhieu AND IDNguyenLieu = @idNL

    -- 4. Tính lại tổng tiền cho toàn bộ phiếu đó
    DECLARE @newTotal FLOAT = (SELECT SUM(SoLuong * GiaNhap) FROM ChiTietPhieuNhap WHERE IDPhieuNhap = @idPhieu)
    UPDATE PhieuNhap SET TongTien = @newTotal WHERE ID = @idPhieu
END
GO
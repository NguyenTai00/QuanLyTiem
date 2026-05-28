USE QuanLyTiem
GO

CREATE OR ALTER PROC USP_GetIngredientInventoryReport
    @isAscending BIT -- 1: Tăng dần, 0: Giảm dần
AS
BEGIN
    SELECT 
        ID AS [Mã NL],
        TenNL AS [Tên nguyên liệu],
        DonViTinh AS [ĐVT],
        SoLuongTon AS [Số lượng tồn],
        -- Lấy giá nhập của lần gần nhất trong bảng Chi tiết phiếu nhập
        ISNULL((SELECT TOP 1 GiaNhap FROM ChiTietPhieuNhap WHERE IDNguyenLieu = NguyenLieu.ID ORDER BY ID DESC), 0) AS [Giá nhập gần nhất],
        -- Giá trị tồn = Số lượng trong kho * Giá nhập gần nhất
        (SoLuongTon * ISNULL((SELECT TOP 1 GiaNhap FROM ChiTietPhieuNhap WHERE IDNguyenLieu = NguyenLieu.ID ORDER BY ID DESC), 0)) AS [Giá trị tồn]
    FROM NguyenLieu
    ORDER BY 
        CASE WHEN @isAscending = 1 THEN SoLuongTon END ASC,
        CASE WHEN @isAscending = 0 THEN SoLuongTon END DESC
END
GO
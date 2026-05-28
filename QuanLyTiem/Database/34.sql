USE QuanLyTiem
GO

CREATE OR ALTER PROC USP_GetIngredientInventoryReport
    @isAscending BIT,   -- Tham số 1
    @loai NVARCHAR(100) -- Tham số 2 (Bạn đang thiếu cái này ở dưới SQL)
AS
BEGIN
    SELECT 
        ID AS [Mã NL], 
        TenNL AS [Tên nguyên liệu], 
        LoaiNL AS [Loại], 
        DonViTinh AS [ĐVT],
        SoLuongTon AS [Số lượng tồn],
        ISNULL((SELECT TOP 1 GiaNhap FROM ChiTietPhieuNhap WHERE IDNguyenLieu = NguyenLieu.ID ORDER BY ID DESC), 0) AS [Giá nhập gần nhất],
        (SoLuongTon * ISNULL((SELECT TOP 1 GiaNhap FROM ChiTietPhieuNhap WHERE IDNguyenLieu = NguyenLieu.ID ORDER BY ID DESC), 0)) AS [Giá trị tồn]
    FROM NguyenLieu
    WHERE (@loai = N'Tất cả' OR LoaiNL = @loai)
    ORDER BY 
        CASE WHEN @isAscending = 1 THEN SoLuongTon END ASC,
        CASE WHEN @isAscending = 0 THEN SoLuongTon END DESC
END
GO
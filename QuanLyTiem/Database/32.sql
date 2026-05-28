USE QuanLyTiem
GO

-- 1. Thêm cột LoaiNL (Loại nguyên liệu) vào bảng
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('NguyenLieu') AND name = 'LoaiNL')
BEGIN
    ALTER TABLE NguyenLieu ADD LoaiNL NVARCHAR(100) DEFAULT N'Chưa phân loại';
END
GO

-- 2. Cập nhật dữ liệu mẫu để bạn test lọc
UPDATE NguyenLieu SET LoaiNL = N'Thực phẩm tươi' WHERE TenNL LIKE N'%Thịt%' OR TenNL LIKE N'%Cá%';
UPDATE NguyenLieu SET LoaiNL = N'Gia vị' WHERE TenNL LIKE N'%Muối%' OR TenNL LIKE N'%Đường%';
GO

-- 3. Sửa lại Procedure lấy báo cáo (Thêm tham số lọc theo Loại)
CREATE OR ALTER PROC USP_GetIngredientReport
    @isAscending BIT,
    @loai NVARCHAR(100) -- 'Tất cả' hoặc tên loại cụ thể
AS
BEGIN
    SELECT 
        ID AS [Mã NL], TenNL AS [Tên nguyên liệu], LoaiNL AS [Loại], DonViTinh AS [ĐVT],
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
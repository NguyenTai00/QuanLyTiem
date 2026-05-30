USE QuanLyTiem
GO

-- 1. Lấy danh sách phiếu nhập chi tiết cho bảng
CREATE OR ALTER PROC USP_GetImportReportList
    @fromDate DATE, @toDate DATE, @idNCC INT -- 0 là xem tất cả NCC
AS
BEGIN
    SELECT 
        pn.ID AS [Mã Phiếu],
        pn.NgayNhap AS [Ngày Nhập],
        ncc.TenNCC AS [Nhà Cung Cấp],
        nv.HoTen AS [Người Nhập],
        pn.TongTien AS [Tổng Tiền]
    FROM PhieuNhap pn
    JOIN NhaCungCap ncc ON pn.IDNhaCungCap = ncc.ID
    JOIN NhanVien nv ON pn.IDNhanVien = nv.ID
    WHERE CAST(pn.NgayNhap AS DATE) BETWEEN @fromDate AND @toDate
    AND (@idNCC = 0 OR pn.IDNhaCungCap = @idNCC)
    ORDER BY pn.NgayNhap DESC
END
GO

-- 2. Lấy dữ liệu tổng hợp cho các ô bên trái
CREATE OR ALTER PROC USP_GetImportSummary
    @fromDate DATE, @toDate DATE, @idNCC INT
AS
BEGIN
    SELECT 
        COUNT(pn.ID) as TotalReceipts,
        SUM(pn.TongTien) as TotalAmount,
        COUNT(DISTINCT ctpn.IDNguyenLieu) as TotalIngredients,
        (SELECT TOP 1 nl.TenNL 
         FROM ChiTietPhieuNhap ctpn2 
         JOIN NguyenLieu nl ON ctpn2.IDNguyenLieu = nl.ID
         JOIN PhieuNhap pn2 ON ctpn2.IDPhieuNhap = pn2.ID
         WHERE CAST(pn2.NgayNhap AS DATE) BETWEEN @fromDate AND @toDate
         GROUP BY nl.TenNL ORDER BY SUM(ctpn2.SoLuong) DESC) as MostImported
    FROM PhieuNhap pn
    LEFT JOIN ChiTietPhieuNhap ctpn ON pn.ID = ctpn.IDPhieuNhap
    WHERE CAST(pn.NgayNhap AS DATE) BETWEEN @fromDate AND @toDate
    AND (@idNCC = 0 OR pn.IDNhaCungCap = @idNCC)
END
GO
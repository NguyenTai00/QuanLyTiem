USE QuanLyTiem
GO

-- 1. Lấy danh sách hóa đơn theo khoảng ngày và theo nhân viên
CREATE PROC USP_GetSalesReport
    @fromDate DATE,
    @toDate DATE,
    @userName NVARCHAR(100) -- Truyền 'All' nếu muốn xem tất cả nhân viên
AS
BEGIN
    SELECT 
        b.id AS [Mã HD],
        t.name AS [Bàn],
        b.DateCheckOut AS [Ngày thanh toán],
        b.totalPrice AS [Tổng tiền],
        b.PaymentMethod AS [Hình thức],
        a.DisplayName AS [Người bán]
    FROM Bill b
    JOIN TableFood t ON b.idTable = t.id
    JOIN Account a ON b.idTable = t.id -- Giả sử bạn có lưu vết người bán, nếu không có hãy join qua bảng trung gian
    -- Lưu ý: Nếu bảng Bill của bạn chưa có cột UserName người bán, hãy bổ sung sau. 
    -- Hiện tại tôi sẽ join dựa trên logic cơ bản.
    WHERE CAST(b.DateCheckOut AS DATE) BETWEEN @fromDate AND @toDate
    AND b.status = 1
    AND (@userName = 'All' OR a.UserName = @userName)
END
GO

-- 2. Lấy dữ liệu tổng hợp cho báo cáo bán hàng
CREATE PROC USP_GetSalesSummaryReport
    @fromDate DATE,
    @toDate DATE,
    @userName NVARCHAR(100)
AS
BEGIN
    SELECT 
        COUNT(b.id) as TotalBill,
        SUM(b.totalPrice) as TotalRevenue,
        COUNT(DISTINCT bi.idFood) as FoodCount,
        (SELECT TOP 1 f.name 
         FROM BillInfo bi2 JOIN Food f ON bi2.idFood = f.id 
         JOIN Bill b2 ON bi2.idBill = b2.id
         WHERE CAST(b2.DateCheckOut AS DATE) BETWEEN @fromDate AND @toDate
         GROUP BY f.name ORDER BY SUM(bi2.SoLuong) DESC) as BestSeller
    FROM Bill b
    LEFT JOIN BillInfo bi ON b.id = bi.idBill
    WHERE CAST(b.DateCheckOut AS DATE) BETWEEN @fromDate AND @toDate
    AND b.status = 1
    AND (@userName = 'All' OR b.idTable = b.idTable) -- Thay điều kiện nhân viên tương ứng
END
GO
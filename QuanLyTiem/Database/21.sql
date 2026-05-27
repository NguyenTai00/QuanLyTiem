USE QuanLyTiem
GO

-- 1. Lấy danh sách hóa đơn theo ngày
CREATE PROC USP_GetReportByBill @date DATE
AS
BEGIN
    SELECT b.id AS [Mã HD], t.name AS [Bàn], b.DateCheckIn AS [Giờ vào], 
           b.DateCheckOut AS [Giờ ra], b.discount AS [Giảm giá %], 
           b.totalPrice AS [Thành tiền], b.PaymentMethod AS [Hình thức TT]
    FROM Bill b 
    JOIN TableFood t ON b.idTable = t.id
    WHERE CAST(b.DateCheckOut AS DATE) = @date AND b.status = 1
END
GO

-- 2. Lấy danh sách mặt hàng bán được theo ngày
CREATE PROC USP_GetReportByFood @date DATE
AS
BEGIN
    SELECT f.name AS [Tên món], SUM(bi.SoLuong) AS [Số lượng], 
           f.price AS [Đơn giá], SUM(f.price * bi.SoLuong * (100 - bi.discount) / 100) AS [Doanh thu]
    FROM BillInfo bi
    JOIN Bill b ON bi.idBill = b.id
    JOIN Food f ON bi.idFood = f.id
    WHERE CAST(b.DateCheckOut AS DATE) = @date AND b.status = 1
    GROUP BY f.name, f.price
END
GO

-- 3. Lấy các con số tổng hợp (Thanh bên trái form)
CREATE PROC USP_GetDailySummary @date DATE
AS
BEGIN
    -- Tổng số hóa đơn
    DECLARE @totalBill INT = (SELECT COUNT(*) FROM Bill WHERE CAST(DateCheckOut AS DATE) = @date AND status = 1)
    -- Tổng tiền
    DECLARE @totalRevenue FLOAT = (SELECT SUM(totalPrice) FROM Bill WHERE CAST(DateCheckOut AS DATE) = @date AND status = 1)
    -- Số mặt hàng khác nhau đã bán
    DECLARE @totalFoodCount INT = (SELECT COUNT(DISTINCT idFood) FROM BillInfo bi JOIN Bill b ON bi.idBill = b.id WHERE CAST(b.DateCheckOut AS DATE) = @date AND b.status = 1)
    -- Mặt hàng bán chạy nhất
    DECLARE @bestSeller NVARCHAR(100) = (SELECT TOP 1 f.name FROM BillInfo bi JOIN Bill b ON bi.idBill = b.id JOIN Food f ON bi.idFood = f.id WHERE CAST(b.DateCheckOut AS DATE) = @date AND b.status = 1 GROUP BY f.name ORDER BY SUM(bi.SoLuong) DESC)

    SELECT ISNULL(@totalBill, 0) as TotalBill, 
           ISNULL(@totalRevenue, 0) as TotalRevenue, 
           ISNULL(@totalFoodCount, 0) as FoodCount, 
           ISNULL(@bestSeller, N'Chưa có') as BestSeller
END
GO
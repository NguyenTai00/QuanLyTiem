USE QuanLyTiem
GO

ALTER PROC USP_GetReportByBill @date DATE
AS
BEGIN
    SELECT 
        b.id AS [Mã HD], 
        t.name AS [Bàn], 
        b.DateCheckIn AS [Giờ vào], 
        b.DateCheckOut AS [Giờ ra],
        -- Logic gộp tên món và % giảm giá thành chuỗi
        ISNULL((
            SELECT STRING_AGG(CAST(f.name + ' (' + CAST(bi.discount AS NVARCHAR) + '%)' AS NVARCHAR(MAX)), ', ')
            FROM BillInfo bi 
            JOIN Food f ON bi.idFood = f.id 
            WHERE bi.idBill = b.id AND bi.discount > 0
        ), N'Không giảm') AS [Giảm giá món],
        b.totalPrice AS [Thành tiền], 
        b.PaymentMethod AS [Hình thức TT]
    FROM Bill b 
    JOIN TableFood t ON b.idTable = t.id
    WHERE CAST(b.DateCheckOut AS DATE) = @date AND b.status = 1
END
GO
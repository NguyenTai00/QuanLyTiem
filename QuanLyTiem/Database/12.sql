USE QuanLyTiem
GO

-- 1. Đảm bảo bảng có cột discount (Nếu có rồi lệnh này sẽ báo lỗi, bạn cứ bỏ qua)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('BillInfo') AND name = 'discount')
BEGIN
    ALTER TABLE BillInfo ADD discount INT DEFAULT 0
END
GO

-- 2. Xóa Procedure cũ nếu nó đang tồn tại lỗi
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'USP_GetListMenuByTable')
BEGIN
    DROP PROC USP_GetListMenuByTable
END
GO

-- 3. Tạo mới Procedure với đầy đủ cột discount
CREATE PROC USP_GetListMenuByTable
    @idTable INT
AS
BEGIN
    SELECT 
        f.name, 
        bi.SoLuong AS [count], 
        f.price, 
        bi.discount, -- Cột này phải xuất hiện ở đây
        f.price * bi.SoLuong AS [totalPrice] 
    FROM BillInfo AS bi
    INNER JOIN Bill AS b ON bi.idBill = b.id
    INNER JOIN Food AS f ON bi.idFood = f.id
    WHERE b.status = 0 AND b.idTable = @idTable
END
GO
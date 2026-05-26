USE QuanLyTiem
GO

ALTER PROC [dbo].[USP_GetListMenuByTable]
    @idTable INT
AS
BEGIN
    SELECT 
        f.name AS [name], 
        bi.SoLuong AS [count], 
        f.price AS [price], 
        ISNULL(bi.discount, 0) AS [discount], 
        f.id AS [idFood], 
        -- ĐÂY LÀ CỘT MÀ C# ĐANG TÌM:
        ((f.price * bi.SoLuong) * (100 - ISNULL(bi.discount, 0)) / 100) AS [totalPrice] 
    FROM BillInfo AS bi
    INNER JOIN Bill AS b ON bi.idBill = b.id
    INNER JOIN Food AS f ON bi.idFood = f.id
    WHERE b.status = 0 AND b.idTable = @idTable
END
GO
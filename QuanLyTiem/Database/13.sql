ALTER PROC USP_GetListMenuByTable
    @idTable INT
AS
BEGIN
    SELECT 
        f.name, 
        bi.SoLuong AS [count], 
        f.price, 
        bi.discount, 
        f.id AS [idFood], -- THÊM DÒNG NÀY
        f.price * bi.SoLuong AS [totalPrice] 
    FROM BillInfo AS bi
    INNER JOIN Bill AS b ON bi.idBill = b.id
    INNER JOIN Food AS f ON bi.idFood = f.id
    WHERE b.status = 0 AND b.idTable = @idTable
END
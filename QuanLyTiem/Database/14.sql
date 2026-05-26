ALTER PROC USP_InsertBillInfo
    @idBill INT, @idFood INT, @count INT, @discount INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood)
    BEGIN
        -- Cập nhật số lượng VÀ cập nhật luôn mức giảm giá mới
        UPDATE BillInfo 
        SET SoLuong = SoLuong + @count, 
            discount = @discount 
        WHERE idBill = @idBill AND idFood = @idFood
        
        -- Nếu sau khi cộng mà SL <= 0 thì xóa
        DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood AND SoLuong <= 0
    END
    ELSE
    BEGIN
        IF (@count > 0)
            INSERT INTO BillInfo (idBill, idFood, SoLuong, discount) 
            VALUES (@idBill, @idFood, @count, @discount)
    END
END
ALTER PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @count INT,
    @discount INT
AS
BEGIN
    DECLARE @isExistBillInfo INT
    DECLARE @foodCount INT = 1

    SELECT @isExistBillInfo = id,
           @foodCount = SoLuong
    FROM BillInfo
    WHERE idBill = @idBill
      AND idFood = @idFood

    IF (@isExistBillInfo > 0)
    BEGIN
        UPDATE BillInfo
        SET SoLuong = SoLuong + @count,
            discount = @discount
        WHERE idFood = @idFood
          AND idBill = @idBill
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo(idBill, idFood, SoLuong, discount)
        VALUES(@idBill, @idFood, @count, @discount)
    END
END
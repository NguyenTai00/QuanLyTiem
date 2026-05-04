ALTER PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @SoLuong INT
AS
BEGIN
    DECLARE @isExistBillInfo INT
    DECLARE @foodCount INT = 0
    
    -- Kiểm tra món đó đã có trong hóa đơn chưa
    SELECT @isExistBillInfo = id, @foodCount = b.SoLuong 
    FROM BillInfo AS b 
    WHERE idBill = @idBill AND idFood = @idFood

    IF (@isExistBillInfo IS NOT NULL)
    BEGIN
        DECLARE @newCount INT = @foodCount + @SoLuong
        IF (@newCount > 0)
            UPDATE BillInfo SET SoLuong = @newCount WHERE id = @isExistBillInfo
        ELSE
            DELETE BillInfo WHERE id = @isExistBillInfo -- Nếu số lượng <= 0 thì XÓA món đó
    END
    ELSE
    BEGIN
        IF (@SoLuong > 0)
            INSERT INTO BillInfo (idBill, idFood, SoLuong) VALUES (@idBill, @idFood, @SoLuong)
    END
END
-- 1. Thêm cột giảm giá vào bảng BillInfo
ALTER TABLE BillInfo ADD discount INT DEFAULT 0
GO

-- 2. Cập nhật Stored Procedure thêm món
ALTER PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @count INT,
    @discount INT -- Thêm tham số này
AS
BEGIN
    DECLARE @isExistBillInfo INT
    DECLARE @foodCount INT = 0
    
    SELECT @isExistBillInfo = id, @foodCount = SoLuong 
    FROM BillInfo 
    WHERE idBill = @idBill AND idFood = @idFood

    IF (@isExistBillInfo IS NOT NULL)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
            -- Nếu món đã có, cập nhật số lượng mới và mức giảm giá mới nhất
            UPDATE BillInfo SET SoLuong = @newCount, discount = @discount WHERE id = @isExistBillInfo
        ELSE
            DELETE BillInfo WHERE id = @isExistBillInfo
    END
    ELSE
    BEGIN
        IF (@count > 0)
            INSERT INTO BillInfo (idBill, idFood, SoLuong, discount) 
            VALUES (@idBill, @idFood, @count, @discount)
    END
END
GO
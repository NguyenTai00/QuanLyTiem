CREATE PROC USP_UpdateDiscount
    @idBill INT,
    @idFood INT,
    @discount INT
AS
BEGIN
    UPDATE BillInfo
    SET discount = @discount
    WHERE idBill = @idBill
      AND idFood = @idFood
END
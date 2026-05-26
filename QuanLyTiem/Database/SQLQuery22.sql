DROP PROC USP_UpdateFoodDiscount

CREATE PROC USP_UpdateFoodDiscount
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
CREATE PROC USP_UpdateInventory @idNL INT, @count FLOAT
AS
BEGIN
    UPDATE NguyenLieu 
    SET SoLuongTon = SoLuongTon + @count 
    WHERE ID = @idNL
END
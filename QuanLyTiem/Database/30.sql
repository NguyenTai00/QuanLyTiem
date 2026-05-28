ALTER PROC USP_Login
    @userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
    -- Phải SELECT thêm cột IDNhanVien ở đây
    SELECT UserName, DisplayName, PassWord, Type, IDNhanVien 
    FROM Account 
    WHERE UserName = @userName AND PassWord = @passWord
END
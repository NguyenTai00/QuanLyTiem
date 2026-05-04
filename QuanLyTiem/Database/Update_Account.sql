CREATE PROC USP_UpdateAccount
    @userName NVARCHAR(100),
    @displayName NVARCHAR(100),
    @password NVARCHAR(100),
    @newPassword NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra xem mật khẩu cũ có đúng không
    DECLARE @isRightPass INT = 0
    SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName AND PassWord = @password

    IF (@isRightPass = 1)
    BEGIN
        -- Nếu không nhập mật khẩu mới (@newPassword trống) thì chỉ cập nhật Tên hiển thị
        IF (@newPassword = NULL OR @newPassword = '')
        BEGIN
            UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
        END
        ELSE -- Nếu có nhập mật khẩu mới thì cập nhật cả hai
        BEGIN
            UPDATE Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
        END
    END
END
GO
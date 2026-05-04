

CREATE DATABASE QuanLyTiem;
GO

USE QuanLyTiem;
GO

-- 1. BẢNG TÀI KHOẢN
CREATE TABLE Account
(
    UserName NVARCHAR(100) PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL,
    PassWord NVARCHAR(100) NOT NULL,
    Type INT NOT NULL DEFAULT 0
);
GO

-- 2. BẢNG DANH MỤC MÓN ĂN
CREATE TABLE FoodCategory
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
);
GO

-- 3. BẢNG MÓN ĂN
CREATE TABLE Food
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    idCategory INT NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Food_Category FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
);
GO

-- 4. BẢNG BÀN ĂN
CREATE TABLE TableFood
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
    status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
);
GO

-- 5. BẢNG HÓA ĐƠN
CREATE TABLE Bill
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE NULL,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0,
    discount INT NULL DEFAULT 0,
    totalPrice FLOAT NULL,
    CONSTRAINT FK_Bill_TableFood FOREIGN KEY (idTable) REFERENCES TableFood(id)
);
GO

-- 6. BẢNG CHI TIẾT HÓA ĐƠN
CREATE TABLE BillInfo
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,
    CONSTRAINT FK_BillInfo_Bill FOREIGN KEY (idBill) REFERENCES Bill(id),
    CONSTRAINT FK_BillInfo_Food FOREIGN KEY (idFood) REFERENCES Food(id)
);
GO

-- DỮ LIỆU MẪU

INSERT INTO Account(UserName, DisplayName, PassWord, Type)
VALUES
(N'Admin', N'Quản trị', N'123', 1),
(N'NhanVien', N'Nhân viên', N'123', 0);
GO

INSERT INTO FoodCategory(name)
VALUES
(N'Pizza'),
(N'Gà rán'),
(N'Kimbap'),
(N'Nước uống'),
(N'Đồ chiên');
GO

INSERT INTO Food(name, idCategory, price)
VALUES
(N'Pizza bò', 1, 50000),
(N'Pizza xúc xích', 1, 45000),
(N'Gà rán truyền thống', 2, 30000),
(N'Kimbap trứng', 3, 20000),
(N'Coca Cola', 4, 10000),
(N'Khoai tây chiên', 5, 20000);
GO

INSERT INTO TableFood(name, status)
VALUES
(N'Bàn 1', N'Trống'),
(N'Bàn 2', N'Trống'),
(N'Bàn 3', N'Trống'),
(N'Bàn VIP', N'Trống');
GO

INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status, discount, totalPrice)
VALUES
(GETDATE(), GETDATE(), 1, 1, 0, 80000),
(GETDATE(), NULL, 2, 0, 0, NULL);
GO

INSERT INTO BillInfo(idBill, idFood, SoLuong)
VALUES
(1, 1, 1),
(1, 5, 3),
(2, 3, 2);
GO

-- STORED PROCEDURES

CREATE PROC USP_Login
    @userName NVARCHAR(100),
    @passWord NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM Account
    WHERE UserName = @userName AND PassWord = @passWord;
END
GO

CREATE PROC USP_GetTableList
AS
BEGIN
    SELECT * FROM TableFood;
END
GO

CREATE PROC USP_GetListFoodByCategory
    @idCategory INT
AS
BEGIN
    SELECT * 
    FROM Food
    WHERE idCategory = @idCategory;
END
GO

CREATE PROC USP_InsertBill
    @idTable INT
AS
BEGIN
    INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status, discount)
    VALUES (GETDATE(), NULL, @idTable, 0, 0);
END
GO

CREATE PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @SoLuong INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood)
    BEGIN
        UPDATE BillInfo
        SET SoLuong = SoLuong + @SoLuong
        WHERE idBill = @idBill AND idFood = @idFood;
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo(idBill, idFood, SoLuong)
        VALUES(@idBill, @idFood, @SoLuong);
    END
END
GO

CREATE PROC USP_GetListBillByDate
    @checkIn DATE,
    @checkOut DATE
AS
BEGIN
    SELECT 
        t.name AS [Tên bàn],
        b.totalPrice AS [Tổng tiền],
        b.DateCheckIn AS [Ngày vào],
        b.DateCheckOut AS [Ngày ra],
        b.discount AS [Giảm giá]
    FROM Bill b
    INNER JOIN TableFood t ON b.idTable = t.id
    WHERE b.DateCheckIn >= @checkIn
      AND b.DateCheckOut <= @checkOut
      AND b.status = 1;
END
GO
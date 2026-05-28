USE QuanLyTiem
GO

-- 1. Xóa Trigger tự động trừ kho (nếu đã tạo)
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'TRG_UpdateInventoryAfterSales')
    DROP TRIGGER TRG_UpdateInventoryAfterSales;
GO

-- 2. Xóa bảng Định lượng
IF EXISTS (SELECT * FROM sys.objects WHERE name = 'DinhLuong')
    DROP TABLE DinhLuong;
GO
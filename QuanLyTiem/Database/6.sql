USE QuanLyTiem
GO

-- 1. Thêm cột Status vào bảng Food (1 là đang bán, 0 là đã ngừng bán)
ALTER TABLE Food ADD status INT NOT NULL DEFAULT 1
GO

-- 2. Cập nhật tất cả món ăn hiện tại thành đang bán (status = 1)
UPDATE Food SET status = 1
GO
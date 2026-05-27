USE QuanLyTiem
GO

-- BƯỚC 1: XỬ LÝ BẢNG ACCOUNT (QUAN HỆ 1-1)
-- Nếu có dữ liệu trùng, ta tạm thời gán NULL để dọn đường tạo ràng buộc
UPDATE Account SET IDNhanVien = NULL; 

-- Thêm ràng buộc UNIQUE (1 nhân viên - 1 tài khoản)
-- Nếu lệnh này vẫn lỗi, bạn hãy vào bảng Account xóa bớt các dòng trùng đi nhé.
IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'UC_Account_Employee')
    ALTER TABLE Account DROP CONSTRAINT UC_Account_Employee;
GO
ALTER TABLE Account ADD CONSTRAINT UC_Account_Employee UNIQUE (IDNhanVien);
GO


-- BƯỚC 2: XỬ LÝ BẢNG PHIEUNHAP (DỌN DẸP ĐỂ THÊM CỘT)
-- Xóa hết dữ liệu rác trong bảng Phiếu Nhập để không bị lỗi NOT NULL
DELETE FROM ChiTietPhieuNhap;
DELETE FROM PhieuNhap;
GO

-- Xóa cột cũ nếu nó lỡ tồn tại mà bị lỗi
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('PhieuNhap') AND name = 'IDNhanVien')
    ALTER TABLE PhieuNhap DROP COLUMN IDNhanVien;
GO

-- Thêm lại cột IDNhanVien (Cho phép NULL trước để không lỗi, sau đó mới nối dây)
ALTER TABLE PhieuNhap ADD IDNhanVien INT;
GO


-- BƯỚC 3: TẠO ĐƯỜNG DÂY KẾT NỐI (KHÓA NGOẠI)
-- Nối từ PhieuNhap sang NhanVien
ALTER TABLE PhieuNhap ADD CONSTRAINT FK_PhieuNhap_NhanVien 
FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);
GO

-- Kiểm tra lại kết quả
sp_help PhieuNhap
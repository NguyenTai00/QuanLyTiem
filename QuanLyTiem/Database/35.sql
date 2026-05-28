USE QuanLyTiem
GO

-- 1. KẾT NỐI NHÂN VIÊN VÀ TÀI KHOẢN (Mỗi nhân viên 1 tài khoản)
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Account_NhanVien')
BEGIN
    ALTER TABLE Account ADD CONSTRAINT FK_Account_NhanVien FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);
END
GO

-- 2. KẾT NỐI NHÂN VIÊN VÀ PHIẾU NHẬP (Nhân viên nào lập phiếu)
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_PhieuNhap_NhanVien')
BEGIN
    ALTER TABLE PhieuNhap ADD CONSTRAINT FK_PhieuNhap_NhanVien FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID);
END
GO

-- 3. KẾT NỐI NHÀ CUNG CẤP VÀ PHIẾU NHẬP (Nhập từ nhà cung cấp nào)
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_PhieuNhap_NhaCungCap')
BEGIN
    ALTER TABLE PhieuNhap ADD CONSTRAINT FK_PhieuNhap_NhaCungCap FOREIGN KEY (IDNhaCungCap) REFERENCES NhaCungCap(ID);
END
GO

-- 4. KẾT NỐI PHIẾU NHẬP VÀ CHI TIẾT PHIẾU NHẬP
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_CTPN_PhieuNhap')
BEGIN
    ALTER TABLE ChiTietPhieuNhap ADD CONSTRAINT FK_CTPN_PhieuNhap FOREIGN KEY (IDPhieuNhap) REFERENCES PhieuNhap(ID);
END
GO

-- 5. KẾT NỐI NGUYÊN LIỆU VÀ CHI TIẾT PHIẾU NHẬP
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_CTPN_NguyenLieu')
BEGIN
    ALTER TABLE ChiTietPhieuNhap ADD CONSTRAINT FK_CTPN_NguyenLieu FOREIGN KEY (IDNguyenLieu) REFERENCES NguyenLieu(ID);
END
GO

-- 6. KẾT NỐI DANH MỤC VÀ MÓN ĂN
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Food_Category')
BEGIN
    ALTER TABLE Food ADD CONSTRAINT FK_Food_Category FOREIGN KEY (idCategory) REFERENCES FoodCategory(id);
END
GO

-- 7. KẾT NỐI MÓN ĂN VÀ CHI TIẾT HÓA ĐƠN
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_BillInfo_Food')
BEGIN
    ALTER TABLE BillInfo ADD CONSTRAINT FK_BillInfo_Food FOREIGN KEY (idFood) REFERENCES Food(id);
END
GO

-- 8. KẾT NỐI HÓA ĐƠN VÀ CHI TIẾT HÓA ĐƠN
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_BillInfo_Bill')
BEGIN
    ALTER TABLE BillInfo ADD CONSTRAINT FK_BillInfo_Bill FOREIGN KEY (idBill) REFERENCES Bill(id);
END
GO

-- 9. KẾT NỐI BÀN ĂN VÀ HÓA ĐƠN
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Bill_TableFood')
BEGIN
    ALTER TABLE Bill ADD CONSTRAINT FK_Bill_TableFood FOREIGN KEY (idTable) REFERENCES TableFood(id);
END
GO
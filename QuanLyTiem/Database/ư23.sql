USE QuanLyTiem
GO

-- 1. Bảng Nguyên Liệu (Trung tâm của kho)
CREATE TABLE NguyenLieu (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenNL NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(20), -- kg, lít, thùng, cái...
    SoLuongTon FLOAT DEFAULT 0 -- Số lượng hiện có trong kho
)
GO

-- 2. Bảng Phiếu Nhập (Liên kết NCC và Nhân Viên)
CREATE TABLE PhieuNhap (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NgayNhap DATETIME DEFAULT GETDATE(),
    IDNhaCungCap INT NOT NULL,
    IDNhanVien INT NOT NULL, -- Người thực hiện nhập hàng
    TongTien FLOAT DEFAULT 0,
    CONSTRAINT FK_PhieuNhap_NCC FOREIGN KEY (IDNhaCungCap) REFERENCES NhaCungCap(ID),
    CONSTRAINT FK_PhieuNhap_NV FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(ID)
)
GO

-- 3. Chi Tiết Phiếu Nhập (Liên kết Phiếu Nhập và Nguyên Liệu)
CREATE TABLE ChiTietPhieuNhap (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    IDPhieuNhap INT NOT NULL,
    IDNguyenLieu INT NOT NULL,
    SoLuong FLOAT NOT NULL,
    GiaNhap FLOAT NOT NULL,
    CONSTRAINT FK_CTPN_PN FOREIGN KEY (IDPhieuNhap) REFERENCES PhieuNhap(ID),
    CONSTRAINT FK_CTPN_NL FOREIGN KEY (IDNguyenLieu) REFERENCES NguyenLieu(ID)
)
GO

-- 4. Bảng Định Lượng (Cầu nối giữa Món Ăn và Nguyên Liệu)
-- Ví dụ: Món "Pizza Bò" cần 0.2kg "Thịt bò"
CREATE TABLE DinhLuong (
    IDFood INT NOT NULL,
    IDNguyenLieu INT NOT NULL,
    HamLuong FLOAT NOT NULL, -- Lượng nguyên liệu tiêu hao cho 1 đơn vị món ăn
    PRIMARY KEY (IDFood, IDNguyenLieu),
    FOREIGN KEY (IDFood) REFERENCES Food(id),
    FOREIGN KEY (IDNguyenLieu) REFERENCES NguyenLieu(ID)
)
GO
CREATE DATABASE QuanLySanPham
USE QuanLySanPham
GO

CREATE TABLE NhaCungCap
(
	MaNCC VARCHAR(30), 
	TenNCC NVARCHAR (100), 
	DiaChi NVARCHAR (500),
	CONSTRAINT PK_NCC PRIMARY KEY (MaNCC)
	);

	CREATE TABLE LoaiSanPham
(
	MaLoaiSanPham VARCHAR(30), 
	TenLoaiSanPham NVARCHAR (100), 
	CONSTRAINT PK_LSP PRIMARY KEY (MaLoaiSanPham)
	);


CREATE TABLE SanPham
(
	MaSanPham VARCHAR(30), 
	TenSanPham NVARCHAR (100), 
	MaLoaiSanPham VARCHAR(30), 
	SoLuong INT,
	DonGia FLOAT,
	CONSTRAINT PK_SP PRIMARY KEY (MaSanPham),
	CONSTRAINT FK_SP_LSP FOREIGN KEY (MaLoaiSanPham) REFERENCES LoaiSanPham(MaLoaiSanPham)
	);

	CREATE TABLE PhieuNhap
(
	MaPhieuNhap VARCHAR(30), 
	MaNCC VARCHAR(30), 
	NgayNhap DATE,
	ThanhTien FLOAT,
	CONSTRAINT PK_PN PRIMARY KEY (MaPhieuNhap),
	CONSTRAINT FK_PN_NCC FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
	);

CREATE TABLE ChiTietPhieuNhap
(
	MaPhieuNhap VARCHAR(30), 
	MaSanPham VARCHAR(30), 
	SoLuong INT,
	DonGia FLOAT,
	CONSTRAINT PK_CTPN PRIMARY KEY (MaPhieuNhap, MaSanPham),
	CONSTRAINT FK_CTPN_PN FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
	CONSTRAINT FK_CTPN_SP FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
	);

INSERT INTO NhaCungCap
VALUES 
('NCC001', 'SamSung', 'TP.HCM'),
('NCC002', 'Sunhouse', 'TP.HCM'),
('NCC003', 'Apple', 'TP.HCM'),
('NCC004', 'Kangroo', 'Hà Nội'),
('NCC005', 'Senko', 'TP.HCM'),
('NCC006', 'Nokia', 'TP.HCM');

INSERT INTO LoaiSanPham
VALUES
('L001', 'Nokia'),
('L002', 'Iphone'),
('L003', 'Galaxy'),
('L004', 'Tivi'),
('L005', 'Laptop');

INSERT INTO SanPham
VALUES
('Nokia01', N'Điện thoại Nokia cảm ứng', 'L001', 100, 2300000),
('Nokia02', N'Điện thoại Nokia cảm ứng thế hệ 2', 'L001', 200, 2500000),
('Iphone01', N'Iphone 11', 'L002', 100, 10000000),
('Iphone02', N'Iphone 11 Pro', 'L002', 10, 15000000),
('Galaxy01', N'Sam sung galaxy S5', 'L003', 10, 5000000),
('Galaxy02', N'Sam sung galaxy a02s', 'L003', 10, 3500000),
('Iphone03', N'Iphone 12', 'L002', 100, 18000000);

SET DATEFORMAT DMY
INSERT INTO PhieuNhap
VALUES
('PN001', 'NCC001', '20/10/2024', 125000000),
('PN002', 'NCC003', '10/10/2024', 500000000),
('PN003', 'NCC006', '04/10/2024', 129000000),
('PN004', 'NCC001', '24/10/2024', 100000000),
('PN005', 'NCC003', '22/10/2024', 190000000);

INSERT INTO ChiTietPhieuNhap
VALUES
('PN003','Nokia01',2300000, 90),
('PN002','Iphone01',10000000, 80),
('PN001','Galaxy01',5000000, 10),
('PN004','Galaxy01',2300000, 10),
('PN005','Iphone01',10000000, 20);
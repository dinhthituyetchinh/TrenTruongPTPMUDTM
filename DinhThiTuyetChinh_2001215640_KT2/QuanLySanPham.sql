USE [QuanLySanPham]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 24/10/2024 16:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [varchar](30) NOT NULL,
	[MaSanPham] [varchar](30) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 24/10/2024 16:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [varchar](30) NOT NULL,
	[TenLoaiSanPham] [nvarchar](100) NULL,
 CONSTRAINT [PK_LSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 24/10/2024 16:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](30) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](500) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 24/10/2024 16:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](30) NOT NULL,
	[MaNCC] [varchar](30) NULL,
	[NgayNhap] [date] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_PN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 24/10/2024 16:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](30) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[MaLoaiSanPham] [varchar](30) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [DonGia]) VALUES (N'PN001', N'Galaxy01', 5000000, 10)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [DonGia]) VALUES (N'PN002', N'Iphone01', 10000000, 80)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [DonGia]) VALUES (N'PN003', N'Nokia01', 2300000, 90)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [DonGia]) VALUES (N'PN004', N'Galaxy01', 2300000, 10)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [DonGia]) VALUES (N'PN005', N'Iphone01', 10000000, 20)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L001', N'Nokia')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L002', N'Iphone')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L003', N'Galaxy')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L004', N'Tivi')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L005', N'Laptop')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'L006', N'fAn')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC001', N'SamSung', N'TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC002', N'Sunhouse', N'TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC003', N'Apple', N'TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC004', N'Kangroo', N'Hà N?i')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC005', N'Senko', N'TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (N'NCC006', N'Nokia', N'TP.HCM')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNCC], [NgayNhap], [ThanhTien]) VALUES (N'PN001', N'NCC001', CAST(N'2024-10-20' AS Date), 125000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNCC], [NgayNhap], [ThanhTien]) VALUES (N'PN002', N'NCC003', CAST(N'2024-10-10' AS Date), 500000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNCC], [NgayNhap], [ThanhTien]) VALUES (N'PN003', N'NCC006', CAST(N'2024-10-04' AS Date), 129000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNCC], [NgayNhap], [ThanhTien]) VALUES (N'PN004', N'NCC001', CAST(N'2024-10-24' AS Date), 100000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNCC], [NgayNhap], [ThanhTien]) VALUES (N'PN005', N'NCC003', CAST(N'2024-10-22' AS Date), 190000000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Galaxy01', N'Sam sung galaxy S5', N'L003', 10, 5000000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Galaxy02', N'Sam sung galaxy a02s', N'L003', 10, 3500000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Iphone01', N'Iphone 11', N'L002', 100, 10000000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Iphone02', N'Iphone 11 Pro', N'L002', 10, 15000000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Iphone03', N'Iphone 12', N'L002', 100, 18000000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Nokia01', N'Điện thoại Nokia cảm ứng', N'L001', 100, 2300000)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaLoaiSanPham], [SoLuong], [DonGia]) VALUES (N'Nokia02', N'Điện thoại Nokia cảm ứng thế hệ 2', N'L001', 200, 2500000)
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PN] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_PN]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_SP] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_SP]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PN_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PN_NCC]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SP_LSP] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SP_LSP]
GO

USE [QLNS]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 17/09/2019 8:18:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](10) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CongTac]    Script Date: 17/09/2019 8:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CongTac](
	[MaCongTac] [varchar](10) NOT NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaChucVu] [varchar](10) NULL,
	[MaPhongBan] [varchar](10) NULL,
	[Luong] [money] NULL,
	[NgayNhanChuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCongTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/09/2019 8:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DanToc] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[SDT] [char](15) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[MaTrinhDoHocVan] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 17/09/2019 8:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [varchar](10) NOT NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 17/09/2019 8:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TrinhDoHocVan](
	[MaTrinhDoHocVan] [varchar](10) NOT NULL,
	[TenTrinhDoHocVan] [nvarchar](50) NULL,
	[ChuyenNganh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTrinhDoHocVan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'cv001', N'Trưởng phòng')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'cv002', N'Phó phòng')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'cv003', N'Thư ký')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'cv004', N'Nhân viên')
INSERT [dbo].[CongTac] ([MaCongTac], [MaNhanVien], [MaChucVu], [MaPhongBan], [Luong], [NgayNhanChuc]) VALUES (N'ct001', N'nv001', N'cv001', N'pb001', 1000000.0000, CAST(N'2020-01-01' AS Date))
INSERT [dbo].[CongTac] ([MaCongTac], [MaNhanVien], [MaChucVu], [MaPhongBan], [Luong], [NgayNhanChuc]) VALUES (N'ct002', N'nv002', N'cv002', N'pb001', 1000000.0000, CAST(N'2020-01-02' AS Date))
INSERT [dbo].[CongTac] ([MaCongTac], [MaNhanVien], [MaChucVu], [MaPhongBan], [Luong], [NgayNhanChuc]) VALUES (N'ct003', N'nv003', N'cv003', N'pb002', 100000.0000, CAST(N'2020-02-02' AS Date))
INSERT [dbo].[CongTac] ([MaCongTac], [MaNhanVien], [MaChucVu], [MaPhongBan], [Luong], [NgayNhanChuc]) VALUES (N'ct004', N'nv004', N'cv004', N'pb002', 1000000.0000, CAST(N'2020-04-04' AS Date))
INSERT [dbo].[CongTac] ([MaCongTac], [MaNhanVien], [MaChucVu], [MaPhongBan], [Luong], [NgayNhanChuc]) VALUES (N'ct005', N'nv005', N'cv004', N'pb001', 100000.0000, CAST(N'2020-04-04' AS Date))
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [DanToc], [GioiTinh], [SDT], [QueQuan], [NgaySinh], [MaTrinhDoHocVan]) VALUES (N'nv001', N'Bùi Mạnh Hoài', N'Kinh', N'Nam', N'84987555666    ', N'Nghệ An', CAST(N'1998-02-10' AS Date), N'tdhv001')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [DanToc], [GioiTinh], [SDT], [QueQuan], [NgaySinh], [MaTrinhDoHocVan]) VALUES (N'nv002', N'Nguyễn Hoàng Long', N'Kinh', N'Nam', N'84987555667    ', N'Hải Dương', CAST(N'1998-04-04' AS Date), N'tdhv001')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [DanToc], [GioiTinh], [SDT], [QueQuan], [NgaySinh], [MaTrinhDoHocVan]) VALUES (N'nv003', N'Nguyễn Duy Minh', N'Kinh', N'Nam', N'84987555668    ', N'Bắc Ninh', CAST(N'1998-07-05' AS Date), N'tdhv002')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [DanToc], [GioiTinh], [SDT], [QueQuan], [NgaySinh], [MaTrinhDoHocVan]) VALUES (N'nv004', N'Trần Nguyễn Quang Thông', N'Tày', N'Nam', N'84987555669    ', N'Hà Tĩnh', CAST(N'1998-02-08' AS Date), N'tdhv003')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [DanToc], [GioiTinh], [SDT], [QueQuan], [NgaySinh], [MaTrinhDoHocVan]) VALUES (N'nv005', N'Nguyễn Thị Ngọc', N'Mường', N'Nữ', N'84987555670    ', N'Thái Nguyên', CAST(N'1998-10-10' AS Date), N'tdhv004')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [DiaChi], [SDT]) VALUES (N'pb001', N'CNTT', N'Học viện kỹ thuật quân sự', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [DiaChi], [SDT]) VALUES (N'pb002', N'ANHTTT', N'Học viện kỹ thuật quân sự', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [DiaChi], [SDT]) VALUES (N'pb003', N'BDATTT', N'Học viện kỹ thuật quân sự', NULL)
INSERT [dbo].[TrinhDoHocVan] ([MaTrinhDoHocVan], [TenTrinhDoHocVan], [ChuyenNganh]) VALUES (N'tdhv001', N'Giáo sư', N'CNTT')
INSERT [dbo].[TrinhDoHocVan] ([MaTrinhDoHocVan], [TenTrinhDoHocVan], [ChuyenNganh]) VALUES (N'tdhv002', N'Phó giáo sư', N'CNTT')
INSERT [dbo].[TrinhDoHocVan] ([MaTrinhDoHocVan], [TenTrinhDoHocVan], [ChuyenNganh]) VALUES (N'tdhv003', N'Tiến sỹ', N'CNTT')
INSERT [dbo].[TrinhDoHocVan] ([MaTrinhDoHocVan], [TenTrinhDoHocVan], [ChuyenNganh]) VALUES (N'tdhv004', N'Thạc sỹ', N'CNTT')
ALTER TABLE [dbo].[CongTac]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[CongTac]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[CongTac]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTrinhDoHocVan])
REFERENCES [dbo].[TrinhDoHocVan] ([MaTrinhDoHocVan])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO

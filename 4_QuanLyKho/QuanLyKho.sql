CREATE TABLE [dbo].[tblChiTietNhap](
	[MaHDNhap] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tblChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChiTietXuat]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietXuat](
	[MaHDXuat] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tblChiTietXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[MaHangHoa] [int] NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[GiaXuat] [int] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHDNhap] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [int] NULL,
	[MaNhaCC] [int] NULL,
 CONSTRAINT [PK_tblHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonXuat]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonXuat](
	[MaHDXuat] [int] NOT NULL,
	[NgayXuat] [date] NULL,
	[TongTien] [nchar](10) NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_tblHoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKhachHang] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [varchar](15) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNhaCC] [int] NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 10/13/2016 4:13:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNhap_tblHangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[tblChiTietNhap] CHECK CONSTRAINT [FK_tblChiTietNhap_tblHangHoa]
GO
ALTER TABLE [dbo].[tblChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNhap_tblHoaDonNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[tblChiTietNhap] CHECK CONSTRAINT [FK_tblChiTietNhap_tblHoaDonNhap]
GO
ALTER TABLE [dbo].[tblChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietXuat_tblHangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[tblChiTietXuat] CHECK CONSTRAINT [FK_tblChiTietXuat_tblHangHoa]
GO
ALTER TABLE [dbo].[tblChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietXuat_tblHoaDonXuat] FOREIGN KEY([MaHDXuat])
REFERENCES [dbo].[tblHoaDonXuat] ([MaHDXuat])
GO
ALTER TABLE [dbo].[tblChiTietXuat] CHECK CONSTRAINT [FK_tblChiTietXuat_tblHoaDonXuat]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonXuat_tblKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tblKhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[tblHoaDonXuat] CHECK CONSTRAINT [FK_tblHoaDonXuat_tblKhachHang]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKho] SET  READ_WRITE 
GO

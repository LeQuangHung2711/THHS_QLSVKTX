USE [QLSVKTX]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 07/12/2022 5:33:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[IDHoaDon] [nvarchar](50) NOT NULL,
	[IDPhong] [nvarchar](50) NOT NULL,
	[SoDien] [nvarchar](50) NULL,
	[SoNuoc] [nvarchar](50) NULL,
	[NgayLapPhieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogIn]    Script Date: 07/12/2022 5:33:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogIn](
	[tk] [nvarchar](50) NULL,
	[mk] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhongKTX]    Script Date: 07/12/2022 5:33:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongKTX](
	[IDPhong] [nvarchar](50) NOT NULL,
	[IDDayNha] [nvarchar](50) NOT NULL,
	[SoLuong] [nvarchar](50) NULL,
	[SoLuongToiDa] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblPhongKTX] PRIMARY KEY CLUSTERED 
(
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 07/12/2022 5:33:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MSSV] [nvarchar](50) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[IDPhong] [nvarchar](50) NOT NULL,
	[NgayVao] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC,
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblHoaDon] ([IDHoaDon], [IDPhong], [SoDien], [SoNuoc], [NgayLapPhieu]) VALUES (N'HD01', N'A201', N'3', N'5', N'7/12/2022')
GO
INSERT [dbo].[tblLogIn] ([tk], [mk]) VALUES (N'admin', N'admin123')
GO
INSERT [dbo].[tblPhongKTX] ([IDPhong], [IDDayNha], [SoLuong], [SoLuongToiDa]) VALUES (N'A201', N'A', N'3', N'10')
INSERT [dbo].[tblPhongKTX] ([IDPhong], [IDDayNha], [SoLuong], [SoLuongToiDa]) VALUES (N'A202', N'A', N'5', N'7')
GO
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [SDT], [GioiTinh], [IDPhong], [NgayVao]) VALUES (N'SV02', N'Hưng', N'0354146830', N'Nam', N'A201', N'7/12/2022')
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblPhongKTX] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tblPhongKTX] ([IDPhong])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblPhongKTX]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblPhongKTX] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tblPhongKTX] ([IDPhong])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblPhongKTX]
GO

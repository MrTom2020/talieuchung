USE [master]
GO
/****** Object:  Database [QL_NT_2]    Script Date: 11/07/2020 19:55:07 ******/
CREATE DATABASE [QL_NT_2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_NT_DATABASE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_NT_2.MDF' , SIZE = 5120KB , MAXSIZE = 102400KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'QL_NT_2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_NT_2_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_NT_2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_NT_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_NT_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_NT_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_NT_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_NT_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_NT_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_NT_2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_NT_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_NT_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_NT_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_NT_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_NT_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_NT_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_NT_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_NT_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_NT_2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_NT_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_NT_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_NT_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_NT_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_NT_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_NT_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_NT_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_NT_2] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_NT_2] SET  MULTI_USER 
GO
ALTER DATABASE [QL_NT_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_NT_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_NT_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_NT_2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_NT_2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_NT_2', N'ON'
GO
USE [QL_NT_2]
GO
/****** Object:  Table [dbo].[DK]    Script Date: 11/07/2020 19:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DK](
	[MaKH] [int] NULL,
	[MaPhong] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[CMND] [int] NULL,
	[SoLuongNguoi] [int] NULL,
	[TienCoc] [float] NULL,
	[NgayThue] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KH]    Script Date: 11/07/2020 19:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KH](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[CMND] [int] NULL,
	[SDT] [int] NULL,
	[NgheNghiep] [nvarchar](50) NULL,
	[Gmail] [nvarchar](50) NULL,
	[hinh] [nvarchar](100) NULL,
	[tinhtrang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/07/2020 19:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] NOT NULL,
	[SoLuongToiDa] [int] NULL,
	[Den] [int] NULL,
	[VoiNuoc] [int] NULL,
	[DongHo] [int] NULL,
	[KhoNuoc] [int] NULL,
	[tinh_trang] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhToanTienPhong]    Script Date: 11/07/2020 19:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToanTienPhong](
	[MaKH] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgayBatDauTinhTien] [date] NULL,
	[MaPhong] [int] NULL,
	[SoDien] [float] NULL,
	[SoNuoc] [float] NULL,
	[TongTien] [float] NULL,
	[NgayTinh] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TraPhong]    Script Date: 11/07/2020 19:55:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraPhong](
	[MaPhong] [int] NULL,
	[SoDien] [float] NULL,
	[SoNuoc] [float] NULL,
	[SoNgayO] [date] NULL,
	[TongTien] [float] NULL,
	[MaKH] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgayBatDauTinhTien] [date] NULL,
	[TinhTrangPhong] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (1, 1, N'Hồ Diên Công', 392225405, 231226373, 2, 200000, CAST(N'2019-01-01' AS Date))
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (2, 2, N'Hồ Diên Thành', 392225405, 231226374, 2, 200000, CAST(N'2019-01-02' AS Date))
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (3, 3, N'lê Thanh Hiệp', 392225405, 231226375, 2, 200000, CAST(N'2019-01-04' AS Date))
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (4, 4, N'Hà anh tuấn', 987654321, 123456789, 2, 200000, CAST(N'2020-01-10' AS Date))
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (5, 5, N'asa', 123222223, 123456789, 2, 200000, CAST(N'2020-01-02' AS Date))
INSERT [dbo].[DK] ([MaKH], [MaPhong], [TenKH], [SDT], [CMND], [SoLuongNguoi], [TienCoc], [NgayThue]) VALUES (4, 6, N'Hà anh tuấn', 987654321, 123456789, 4, 200000, CAST(N'2020-01-02' AS Date))
INSERT [dbo].[KH] ([MaKH], [TenKH], [CMND], [SDT], [NgheNghiep], [Gmail], [hinh], [tinhtrang]) VALUES (1, N'Hồ Diên Công', 231226373, 392225405, N'Sinh Viên', N'hodiecong12c5@gmail.com', NULL, NULL)
INSERT [dbo].[KH] ([MaKH], [TenKH], [CMND], [SDT], [NgheNghiep], [Gmail], [hinh], [tinhtrang]) VALUES (2, N'Hồ Diên Thành', 231226374, 392225405, N'Sinh Viên', N'hodiethanh12c5@gmail.com', NULL, NULL)
INSERT [dbo].[KH] ([MaKH], [TenKH], [CMND], [SDT], [NgheNghiep], [Gmail], [hinh], [tinhtrang]) VALUES (3, N'lê Thanh Hiệp', 231226375, 392225405, N'Sinh Viên', N'lethanhhiep12c5@gmail.com', NULL, NULL)
INSERT [dbo].[KH] ([MaKH], [TenKH], [CMND], [SDT], [NgheNghiep], [Gmail], [hinh], [tinhtrang]) VALUES (4, N'Hà anh tuấn', 123456789, 987654321, N'giáo sư', N'giaosu"gmail.com', NULL, NULL)
INSERT [dbo].[KH] ([MaKH], [TenKH], [CMND], [SDT], [NgheNghiep], [Gmail], [hinh], [tinhtrang]) VALUES (5, N'asa', 123456789, 12233, N'asw', N'1aq', NULL, NULL)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (1, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (2, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (3, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (4, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (5, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (6, 3, 0, 0, 0, 0, 1)
INSERT [dbo].[Phong] ([MaPhong], [SoLuongToiDa], [Den], [VoiNuoc], [DongHo], [KhoNuoc], [tinh_trang]) VALUES (7, 3, 0, 0, 1, 1, 0)
ALTER TABLE [dbo].[DK]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KH] ([MaKH])
GO
ALTER TABLE [dbo].[DK]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThanhToanTienPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThanhToanTienPhong]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KH] ([MaKH])
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KH] ([MaKH])
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
USE [master]
GO
ALTER DATABASE [QL_NT_2] SET  READ_WRITE 
GO

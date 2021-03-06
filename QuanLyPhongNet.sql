USE [master]
GO
/****** Object:  Database [QuanLyPhongNet]    Script Date: 10/30/2021 7:50:26 PM ******/
CREATE DATABASE [QuanLyPhongNet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyPhongNet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\QuanLyPhongNet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyPhongNet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\QuanLyPhongNet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyPhongNet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyPhongNet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyPhongNet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyPhongNet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyPhongNet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyPhongNet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyPhongNet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyPhongNet] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyPhongNet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyPhongNet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyPhongNet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyPhongNet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyPhongNet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyPhongNet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyPhongNet', N'ON'
GO
ALTER DATABASE [QuanLyPhongNet] SET QUERY_STORE = OFF
GO
USE [QuanLyPhongNet]
GO
/****** Object:  Table [dbo].[May]    Script Date: 10/30/2021 7:50:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[May](
	[SoMay] [char](5) NOT NULL,
	[ThongTin] [nvarchar](20) NULL,
 CONSTRAINT [PK_May] PRIMARY KEY CLUSTERED 
(
	[SoMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NapTien]    Script Date: 10/30/2021 7:50:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NapTien](
	[MaNapTien] [int] IDENTITY(1,1) NOT NULL,
	[MaTK] [int] NULL,
	[NgayNap] [date] NULL,
	[SoTienNap] [bigint] NULL,
 CONSTRAINT [PK_NapTien] PRIMARY KEY CLUSTERED 
(
	[MaNapTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuDung]    Script Date: 10/30/2021 7:50:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDung](
	[SoMay] [char](5) NOT NULL,
	[MaTK] [int] NOT NULL,
	[TienSuDung] [int] NULL,
	[TrangThai] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoMay] ASC,
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/30/2021 7:50:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [nvarchar](20) NULL,
	[MatKhau] [varchar](20) NULL,
	[SoTien] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY01', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY02', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY03', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY04', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY05', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY06', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY07', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY08', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY09', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY10', N'i3(11th)/GTX1050
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY11', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY12', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY13', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY14', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY15', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY16', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY17', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY18', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY19', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY20', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY21', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY22', N'i5(11th)/3060Super
')
INSERT [dbo].[May] ([SoMay], [ThongTin]) VALUES (N'MAY23', N'i5(11th)/3060Super
')
GO
SET IDENTITY_INSERT [dbo].[NapTien] ON 

INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (1, 20, CAST(N'2021-10-29' AS Date), 20000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (2, 20, CAST(N'2021-10-29' AS Date), 5000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (5, 20, CAST(N'2021-04-30' AS Date), 20000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (6, 8, CAST(N'2021-04-30' AS Date), 3000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (7, 1, CAST(N'2021-04-30' AS Date), 5000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (8, 13, CAST(N'2021-04-30' AS Date), 230000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (9, 26, CAST(N'2021-05-01' AS Date), 30000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (10, 16, CAST(N'2021-05-01' AS Date), 3000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (11, 27, CAST(N'2021-05-01' AS Date), 25000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (12, 19, CAST(N'2021-05-01' AS Date), 32000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (13, 27, CAST(N'2021-05-05' AS Date), 32000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (14, 28, CAST(N'2021-05-05' AS Date), 12000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (15, 14, CAST(N'2021-05-06' AS Date), 3000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (16, 32, CAST(N'2021-04-05' AS Date), 30000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (17, 12, CAST(N'2021-04-07' AS Date), 12000)
INSERT [dbo].[NapTien] ([MaNapTien], [MaTK], [NgayNap], [SoTienNap]) VALUES (19, 8, CAST(N'2021-10-30' AS Date), 20000)
SET IDENTITY_INSERT [dbo].[NapTien] OFF
GO
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY01', 1, 0, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY02', 24, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY03', 18, 45000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY04', 1, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY05', 10, 70000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY06', 20, 6000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY07', 8, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY08', 9, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY09', 19, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY10', 17, 22000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY11', 14, 90000, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY12', 16, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY13', 23, 30000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY14', 33, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY15', 34, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY16', 22, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY17', 35, 15000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY18', 27, 5000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY19', 28, 0, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY20', 13, 18000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY21', 29, 23000, N'OFF')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY22', 21, 5000, N'ON ')
INSERT [dbo].[SuDung] ([SoMay], [MaTK], [TienSuDung], [TrangThai]) VALUES (N'MAY23', 30, 0, N'OFF')
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (1, N'hoangphuoc', N'1234', 65000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (8, N'trongphuoc', N'456', 42000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (9, N'gaga', N'123', 23000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (10, N'gaga1', N'123', 73000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (12, N'binz', N'799', 10000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (13, N'Gducky', N'18001091', 20000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (14, N'Teacher', N'1001001', 100000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (15, N'Leesin', N'0175', 15000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (16, N'Yasuo', N'0200', 1000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (17, N'Camile', N'20001', 55000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (18, N'Jax', N'jax', 77000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (19, N'Kayle', N'0108', 90000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (20, N'Vayne', N'1008', 41000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (21, N'Yi', N'trumVet', 77000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (22, N'Vi', N'78910', 50000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (23, N'Vex', N'200nam', 35000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (24, N'TF', N'5000', 57000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (26, N'Catiem', N'baonguyentiem', 1000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (27, N'Orn', N'taotankhet', 23000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (28, N'Akali', N'ninja', 36000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (29, N'AnhHungBanPhim', N'Chuimoithhu', 50000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (30, N'Chanlamroi', N'111', 2000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (32, N'Dubi1', N'123', 50000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (33, N'Dubi2', N'111', 30000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (34, N'Dubi3', N'111', 20000)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [SoTien]) VALUES (35, N'Dubi4', N'111', 20000)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
ALTER TABLE [dbo].[NapTien]  WITH CHECK ADD  CONSTRAINT [FK_NapTien_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[NapTien] CHECK CONSTRAINT [FK_NapTien_TaiKhoan]
GO
ALTER TABLE [dbo].[SuDung]  WITH CHECK ADD  CONSTRAINT [FK_SuDung_May] FOREIGN KEY([SoMay])
REFERENCES [dbo].[May] ([SoMay])
GO
ALTER TABLE [dbo].[SuDung] CHECK CONSTRAINT [FK_SuDung_May]
GO
ALTER TABLE [dbo].[SuDung]  WITH CHECK ADD  CONSTRAINT [FK_SuDung_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[SuDung] CHECK CONSTRAINT [FK_SuDung_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [QuanLyPhongNet] SET  READ_WRITE 
GO

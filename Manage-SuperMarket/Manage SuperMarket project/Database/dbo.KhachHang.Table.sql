USE KhachHang
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/10/2024 10:36:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CustomerID] [nchar](10) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[IdentityCard] [bigint] NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [bigint] NULL,
	[Points] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([CustomerID], [CustomerName], [IdentityCard], [Address], [PhoneNumber], [Points]) VALUES (N'C1211     ', N'TranAnhCong', 44203112234, N'14PhuMyHung-Quan7', 913125645, 12)
INSERT [dbo].[KhachHang] ([CustomerID], [CustomerName], [IdentityCard], [Address], [PhoneNumber], [Points]) VALUES (N'C1213     ', N'TranQuocAnh', 55382339941, N'212NguyenHuuTho-NhaBe', 384859345, 2)
INSERT [dbo].[KhachHang] ([CustomerID], [CustomerName], [IdentityCard], [Address], [PhoneNumber], [Points]) VALUES (N'C1312     ', N'LeAnhDat', 4429188332, N'141DienBienPhu-BinhThanh', 986345867, 7)
INSERT [dbo].[KhachHang] ([CustomerID], [CustomerName], [IdentityCard], [Address], [PhoneNumber], [Points]) VALUES (N'C4621     ', N'DoAnhDuy', 77482993371, N'17DienBienPhu-BinhThanh', 834563894, 21)
GO

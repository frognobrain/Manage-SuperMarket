USE SanPham
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/10/2024 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[GoodID] [nchar](10) NOT NULL,
	[GoodName] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Origin] [nvarchar](50) NULL,
	[DateOfManufacture] [date] NULL,
	[ProductShelfLife] [date] NULL,
	[Price] [int] NULL,
	[OriginID] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[GoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

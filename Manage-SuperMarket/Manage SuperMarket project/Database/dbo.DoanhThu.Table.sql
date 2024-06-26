USE DoanhThu
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 4/10/2024 10:35:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Date] [date] NULL,
	[GoodID] [int] NULL,
	[ReportID] [nchar](10) NOT NULL,
	[GoodName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_DaonhThu] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DoanhThu] ([Date], [GoodID], [ReportID], [GoodName], [Quantity], [Price]) VALUES (CAST(N'2024-10-04' AS Date), 2311, N'1231123   ', N'Candy', 7, 10000)
INSERT [dbo].[DoanhThu] ([Date], [GoodID], [ReportID], [GoodName], [Quantity], [Price]) VALUES (CAST(N'2024-10-04' AS Date), 2314, N'2134123   ', N'Break', 2, 50000)
GO

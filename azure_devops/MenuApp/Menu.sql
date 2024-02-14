USE [master]
GO
/****** Object:  Database [Menu]    Script Date: 21.11.2023 19:57:28 ******/
CREATE DATABASE [Menu]
GO
USE [Menu]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 21.11.2023 19:57:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[ImageData] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 21.11.2023 19:57:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 21.11.2023 19:57:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[ImageData] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Category] ([Id], [Name], [ImageData]) VALUES (N'42adb2ab-4bca-4f2a-bb76-0e32908f9d85', N'Soğuk İçecekler', N'C:\Users\hp\Desktop\eternal girl.png')
GO
INSERT [dbo].[Category] ([Id], [Name], [ImageData]) VALUES (N'42adb2ab-4bca-4f2a-bb76-0e32908f9d86', N'Sıcak İçecekler', N'C:\Users\hp\Desktop\art.png')
GO
INSERT [dbo].[Order] ([Id], [ProductId], [Quantity], [Total], [Date]) VALUES (N'017ca051-0cd2-4270-b031-60a9d6e4bfb0', N'42adb2ab-4bca-4f2a-bb76-0e32908f9d88', 5, CAST(50 AS Decimal(18, 0)), CAST(N'2023-11-21' AS Date))
GO
INSERT [dbo].[Order] ([Id], [ProductId], [Quantity], [Total], [Date]) VALUES (N'6e4f22f1-ce61-4220-bdd9-d196e1a467c5', N'42adb2ab-4bca-4f2a-bb76-0e32908f9d89', 5, CAST(125 AS Decimal(18, 0)), CAST(N'2023-11-21' AS Date))
GO
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [ImageData], [Price]) VALUES (N'42adb2ab-4bca-4f2a-bb76-0e32908f9d88', N'Cola', N'42adb2ab-4bca-4f2a-bb76-0e32908f9d85', N'C:\Users\hp\Desktop\u2j8cmu25o0c1.jpg', CAST(10 AS Decimal(18, 0)))
GO
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [ImageData], [Price]) VALUES (N'42adb2ab-4bca-4f2a-bb76-0e32908f9d89', N'Kahve', N'42adb2ab-4bca-4f2a-bb76-0e32908f9d86', N'C:\Users\hp\Desktop\1291142.jpg', CAST(25 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]

USE [ECommerce]
GO
/****** Object:  Table [dbo].[BrandMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_BrandMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoryMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_CategoryMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CatogoryContainer]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatogoryContainer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CatogoryId] [int] NULL,
	[SubCategoryId] [int] NULL,
 CONSTRAINT [PK_CatogoryContainer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ColorMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ColorMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NewArrivals]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewArrivals](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [nvarchar](max) NULL,
 CONSTRAINT [PK_NewArrivals] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [nvarchar](max) NULL,
	[PropertyId] [nvarchar](max) NULL,
 CONSTRAINT [PK_MasterOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PriceMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FromPrice] [nvarchar](max) NULL,
	[ToPrice] [nvarchar](max) NULL,
 CONSTRAINT [PK_PriceMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductContainer]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductContainer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [nvarchar](max) NULL,
	[CategoryId] [nvarchar](max) NULL,
	[BrandId] [nvarchar](max) NULL,
	[ColorId] [nvarchar](max) NULL,
	[SubCategoryId] [nvarchar](max) NULL,
	[Discounted] [nvarchar](max) NULL,
	[DiscountedPrice] [nvarchar](max) NULL,
	[SizeId] [nvarchar](max) NULL,
	[DiscountedPercent] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductContainer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name1] [nvarchar](max) NULL,
	[Name2] [nvarchar](max) NULL,
	[Name3] [nvarchar](max) NULL,
	[ImageUrl1] [nvarchar](max) NULL,
	[ImageUrl2] [nvarchar](max) NULL,
	[ImageUrl3] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SizeMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SizeMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Size] [nvarchar](max) NULL,
 CONSTRAINT [PK_SizeMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategoryMaster]    Script Date: 10/20/2014 12:03:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_SubCategoryMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BrandMaster] ON 

INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (1, N'B1', N'GUCCI')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (2, N'B2', N'ARMANI')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (3, N'B3', N'Louis Vuitton')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (4, N'B4', N'Chanel')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (5, N'B5', N'Roberto Cavalli')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (6, N'B6', N'Valentino')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (7, N'B7', N'Ralph Lauren')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (8, N'B8', N'Miu Miu')
INSERT [dbo].[BrandMaster] ([id], [Code], [Name]) VALUES (9, N'B9', N'McQueen')
SET IDENTITY_INSERT [dbo].[BrandMaster] OFF
SET IDENTITY_INSERT [dbo].[CategoryMaster] ON 

INSERT [dbo].[CategoryMaster] ([id], [Code], [Name]) VALUES (1, N'C1', N'WOMEN')
INSERT [dbo].[CategoryMaster] ([id], [Code], [Name]) VALUES (2, N'C2', N'MEN')
INSERT [dbo].[CategoryMaster] ([id], [Code], [Name]) VALUES (3, N'C3', N'MISCELLANEOUS')
INSERT [dbo].[CategoryMaster] ([id], [Code], [Name]) VALUES (4, N'C4', N'HOME & KITCHEN')
INSERT [dbo].[CategoryMaster] ([id], [Code], [Name]) VALUES (5, N'C5', N'Offer Zone')
SET IDENTITY_INSERT [dbo].[CategoryMaster] OFF
SET IDENTITY_INSERT [dbo].[CatogoryContainer] ON 

INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (1, 1, 1)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (2, 1, 2)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (3, 1, 3)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (4, 1, 4)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (5, 1, 5)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (6, 1, 6)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (7, 1, 7)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (8, 1, 8)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (9, 2, 1)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (10, 2, 2)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (11, 2, 3)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (12, 2, 7)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (13, 2, 8)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (14, 3, 4)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (15, 3, 5)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (16, 3, 8)
INSERT [dbo].[CatogoryContainer] ([id], [CatogoryId], [SubCategoryId]) VALUES (17, 4, 9)
SET IDENTITY_INSERT [dbo].[CatogoryContainer] OFF
SET IDENTITY_INSERT [dbo].[ColorMaster] ON 

INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (1, N'Black')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (2, N'Blue')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (3, N'Green')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (4, N'Red')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (5, N'White')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (6, N'Pink')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (7, N'Beige')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (8, N'Purple')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (9, N'Yellow')
INSERT [dbo].[ColorMaster] ([id], [Name]) VALUES (10, N'Brown')
SET IDENTITY_INSERT [dbo].[ColorMaster] OFF
SET IDENTITY_INSERT [dbo].[NewArrivals] ON 

INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (1, N'1')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (2, N'2')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (3, N'3')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (4, N'4')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (5, N'5')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (6, N'6')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (7, N'7')
INSERT [dbo].[NewArrivals] ([id], [ProductId]) VALUES (8, N'8')
SET IDENTITY_INSERT [dbo].[NewArrivals] OFF
SET IDENTITY_INSERT [dbo].[PriceMaster] ON 

INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (1, N'100', N'500')
INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (2, N'500', N'1000')
INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (3, N'1000', N'1500')
INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (4, N'1500', N'2000')
INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (5, N'2000', N'2500')
INSERT [dbo].[PriceMaster] ([id], [FromPrice], [ToPrice]) VALUES (6, N'2500', N'3000')
SET IDENTITY_INSERT [dbo].[PriceMaster] OFF
SET IDENTITY_INSERT [dbo].[ProductContainer] ON 

INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (1, N'1', N'1', N'1', N'1', N'1', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (2, N'1', N'2', N'2', N'2', N'2', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (3, N'1', N'3', N'3', N'3', N'3', N'0', N'0', N'2', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (4, N'2', N'1', N'2', N'1', N'2', N'0', N'0', N'2', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (5, N'2', N'3', N'1', N'1', N'2', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (6, N'3', N'3', N'3', N'3', N'3', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (7, N'3', N'1', N'1', N'1', N'1', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (8, N'3', N'1', N'1', N'1', N'2', N'0', N'0', N'3', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (9, N'3', N'3', N'3', N'1', N'2', N'0', N'0', N'2', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (10, N'3', N'2', N'3', N'1', N'2', N'0', N'0', N'1', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (11, N'3', N'2', N'1', N'1', N'2', N'0', N'0', N'3', N'0')
INSERT [dbo].[ProductContainer] ([id], [ProductId], [CategoryId], [BrandId], [ColorId], [SubCategoryId], [Discounted], [DiscountedPrice], [SizeId], [DiscountedPercent]) VALUES (12, N'3', N'2', N'1', N'1', N'2', N'0', N'0', N'3', N'0')
SET IDENTITY_INSERT [dbo].[ProductContainer] OFF
SET IDENTITY_INSERT [dbo].[ProductMaster] ON 

INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (1, N'P1', N'ALIQUAM ERAT VOLUTPAT', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/25.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'25')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (2, N'P2', N'ULLAMCORPER SUSCIPIT LOBORTIS', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/31.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'175')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (3, N'P3', N'DEMONSTRAVERUNT LECTORES', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/30.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'550')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (4, N'P4', N'HUMANITATIS PER', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/31.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'1526')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (5, N'P5', N'EODEM MODO TYPI', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/30.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'996')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (6, N'P6', N'CONSUETUDIUM LECTORUM.', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/30.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'584')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (7, N'P7', N'SEQUITUR MUTATIONEM', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/27.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'2569')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (8, N'P8', N'PARUM CLARAM', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/28.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'3200')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (9, N'P9', N'DUIS DOLORE', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/29.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'1577')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (10, N'P10', N'ALIQUAM ERAT VOLUTPAT', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/36.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'519')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (11, N'P11', N'ULLAMCORPER SUSCIPIT LOBORTIS', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/35.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'1239')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (12, N'P12', N'DEMONSTRAVERUNT LECTORES', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/34.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'1577')
INSERT [dbo].[ProductMaster] ([id], [Code], [Name1], [Name2], [Name3], [ImageUrl1], [ImageUrl2], [ImageUrl3], [Description], [Price]) VALUES (13, N'P13', N'PARUM CLARAM', NULL, NULL, N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/33.jpg', NULL, NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', N'1239')
SET IDENTITY_INSERT [dbo].[ProductMaster] OFF
SET IDENTITY_INSERT [dbo].[SizeMaster] ON 

INSERT [dbo].[SizeMaster] ([id], [Size]) VALUES (1, N'M')
INSERT [dbo].[SizeMaster] ([id], [Size]) VALUES (2, N'L')
INSERT [dbo].[SizeMaster] ([id], [Size]) VALUES (3, N'S')
SET IDENTITY_INSERT [dbo].[SizeMaster] OFF
SET IDENTITY_INSERT [dbo].[SubCategoryMaster] ON 

INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (1, N'SC1', N'TShirts', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/4.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (2, N'SC2', N'Shoes', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/3.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (3, N'SC3', N'Shirt', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/5.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (4, N'SC4', N'Fragrance', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/4.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (5, N'SC5', N'Scarf', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/7.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (6, N'SC6', N'Sandal', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/8.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (7, N'SC7', N'Jeans', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/9jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (8, N'SC8', N'Trousers', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/10.jpg')
INSERT [dbo].[SubCategoryMaster] ([id], [Code], [Name], [ImageUrl]) VALUES (9, N'SC8', N'Crockery', N'http://codepeoples.com/tanimdesign.net/tshop/html/images/product/10.jpg')
SET IDENTITY_INSERT [dbo].[SubCategoryMaster] OFF

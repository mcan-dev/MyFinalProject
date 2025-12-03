USE [Northwind]
GO

CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryId] ASC)
)
GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[CategoryId] [int] NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[UnitsInStock] [smallint] NULL,
	CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductId] ASC)
)
GO

INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Beverages')
INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Condiments')

INSERT INTO [dbo].[Products] ([ProductName], [CategoryId], [UnitPrice], [UnitsInStock]) VALUES ('Chai', 1, 18.00, 39)
INSERT INTO [dbo].[Products] ([ProductName], [CategoryId], [UnitPrice], [UnitsInStock]) VALUES ('Chang', 1, 19.00, 17)
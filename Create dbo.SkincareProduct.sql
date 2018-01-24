USE [Inventory]
GO

/****** Object: Table [dbo].[SkincareProduct] Script Date: 1/24/2018 10:27:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP	TABLE [dbo].[SkincareProduct]

CREATE TABLE [dbo].[SkincareProduct] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Product]          VARCHAR (250)    NULL,
    [Brand]            VARCHAR (250)    NULL,
    [Ounces]           FLOAT (53)       NULL,
    [Price]            FLOAT (53)       NULL,
    [PricePerOunce]    FLOAT (53)       NULL,
    [ProductLink]      VARCHAR (250)    NULL,
	[Comments]		VARCHAR(MAX)	NULL,
	[DatePurchased]			DATETIME	NULL,
    [SkincareCategory] UNIQUEIDENTIFIER NULL
);



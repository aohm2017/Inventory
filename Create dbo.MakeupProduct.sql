USE [Inventory]
GO

/****** Object: Table [dbo].[MakeupProduct] Script Date: 1/24/2018 10:27:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE dbo.[MakeupProduct]

CREATE TABLE [dbo].[MakeupProduct] (
    [Id]             UNIQUEIDENTIFIER NOT NULL,
    [Product]        VARCHAR (250)    NULL,
    [Brand]          VARCHAR (250)    NULL,
    [Ounce]          FLOAT (53)       NULL,
    [Price]          FLOAT (53)       NULL,
    [PricePerOunce]  FLOAT (53)       NULL,
    [ProductLink]    VARCHAR (250)    NULL,
	[Comments]		VARCHAR(MAX)	NULL,
	[DatePurchased]			DATETIME	NULL,
    [MakeupCategory] UNIQUEIDENTIFIER NULL
);



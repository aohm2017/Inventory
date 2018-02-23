USE [Inventory]
GO

/****** Object: Table [dbo].[SkincareProduct] Script Date: 2/23/2018 11:41:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SkincareProduct] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Product]          VARCHAR (250)    NULL,
    [Brand]            VARCHAR (250)    NULL,
    [Ounces]           FLOAT (53)       NULL,
    [Price]            FLOAT (53)       NULL,
    [PricePerOunce]    FLOAT (53)       NULL,
    [ProductLink]      VARCHAR (250)    NULL,
    [Comments]         VARCHAR (MAX)    NULL,
    [DatePurchased]    DATETIME         NULL,
    [SkincareCategory] UNIQUEIDENTIFIER NULL
);



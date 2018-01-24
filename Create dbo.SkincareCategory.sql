USE [Inventory]
GO

/****** Object: Table [dbo].[SkincareCategory] Script Date: 1/24/2018 10:27:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SkincareCategory] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Category]    VARCHAR (250)    NULL,
    [Description] VARCHAR (250)    NULL
);



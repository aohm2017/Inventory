USE [Inventory]
GO

/****** Object: Table [dbo].[SkincareCategory] Script Date: 2/23/2018 11:41:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SkincareCategory] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Category]    VARCHAR (250)    NULL,
    [Description] VARCHAR (250)    NULL
);



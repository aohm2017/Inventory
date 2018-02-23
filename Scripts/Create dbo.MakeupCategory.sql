USE [Inventory]
GO

/****** Object: Table [dbo].[MakeupCategory] Script Date: 2/23/2018 11:41:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MakeupCategory] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Category]    VARCHAR (50)     NULL,
    [Description] VARCHAR (250)    NULL,
    [SubCategory] VARCHAR (250)    NULL
);



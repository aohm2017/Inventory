USE [Inventory]
GO

/****** Object: Table [dbo].[MakeupCategory] Script Date: 1/24/2018 10:27:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MakeupCategory] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Category]    VARCHAR (50)     NULL,
    [Description] VARCHAR (250)    NULL
);



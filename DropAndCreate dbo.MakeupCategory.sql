USE [Inventory]
GO

/****** Object: Table [dbo].[MakeupCategory] Script Date: 2/19/2018 6:39:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[MakeupCategory];


GO
CREATE TABLE [dbo].[MakeupCategory] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Category]    VARCHAR (50)     NULL,
	[SubCategory] VARCHAR(50) NULL,
    [Description] VARCHAR (250)    NULL
);



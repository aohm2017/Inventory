USE [Inventory]
GO

/****** Object:  Table [dbo].[MakeupProduct]    Script Date: 2/19/2018 11:20:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VideoGames](
	[Id] [uniqueidentifier] NOT NULL,
	[Product] [varchar](250) NULL,
	[Company] [varchar](250) NULL,
	[Price] [float] NULL,
	[Comments] [varchar](max) NULL,
	[DateStarted] [datetime] NULL,
	[DateCompleted] [datetime] NULL,
	[VideoGameConsole] [uniqueidentifier] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[VideoGames] ADD  CONSTRAINT [DF_VideoGames_Id]  DEFAULT (newid()) FOR [Id]
GO



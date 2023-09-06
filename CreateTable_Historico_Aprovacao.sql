USE [Jupiter]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Historico_Aprovacao]') AND type in (N'U'))
	DROP TABLE [dbo].[Historico_Aprovacao]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Historico_Aprovacao](
	[id_sequencial] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NULL,
	[data] [datetime] NULL,
	[senha] [varchar](30) NULL,
	[operacao] [varchar](50) NULL,
 CONSTRAINT [PK__Historic__A6C6D41BEAA6F3C5] PRIMARY KEY CLUSTERED 
(
	[id_sequencial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [Jupiter]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Configura_Faixas]') AND type in (N'U'))
	DROP TABLE [dbo].[Configura_Faixas]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Configura_Faixas](
	[id_sequencial] [int] IDENTITY(1,1) NOT NULL,
	[faixa] [varchar](100) NULL,
	[vistos] [varchar](10) NULL,
	[aprovacoes] [varchar](10) NULL,
 CONSTRAINT [PK__Configur__A6C6D41BFEEC3CC8] PRIMARY KEY CLUSTERED 
(
	[id_sequencial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



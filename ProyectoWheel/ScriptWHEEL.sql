USE [WHEEL]
GO
/****** Object:  Table [dbo].[Conductor]    Script Date: 19/06/2019 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conductor](
	[rut] [varchar](50) NOT NULL,
	[nombres] [nvarchar](50) NOT NULL,
	[apellido_paterno] [nvarchar](50) NOT NULL,
	[apellido_materno] [nvarchar](50) NOT NULL,
	[sexo] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK_Conductor] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [GestionBarrio]
GO
/****** Object:  User [VsUser]    Script Date: 19/9/2022 17:59:36 ******/
CREATE USER [VsUser] FOR LOGIN [VsUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [VsUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [VsUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [VsUser]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 19/9/2022 17:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NULL,
	[Usuario] [nvarchar](255) NULL,
	[Criticidad] [int] NULL,
	[Fecha] [datetime] NULL,
	[IdUser] [int] NULL,
	[DVH] [int] NULL,
	[Host] [varchar](255) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVV]    Script Date: 19/9/2022 17:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tabla] [varchar](50) NOT NULL,
	[DVV] [int] NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_BACKUP]    Script Date: 19/9/2022 17:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_BACKUP] 
	-- Add the parameters for the stored procedure here
	@DIR1 varchar(max), 
	@DIR2 varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
 


 BACKUP DATABASE [GestionBarrio] 
  TO  DISK = @DIR1
  , DISK = @DIR2

  WITH NOFORMAT, NOINIT,  NAME = N'SQLShackDemo-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,
  STATS = 10
 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_NEXTID]    Script Date: 19/9/2022 17:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Juan Manuel >
-- Create date: <Create Date,,>
-- Description:	<Store para obtener el proximo ID>
-- =============================================
CREATE PROCEDURE [dbo].[SP_NEXTID]
	-- Add the parameters for the stored procedure here
	@Tabla varchar(25)
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
  
  SELECT isnull(IDENT_CURRENT(@Tabla) + IDENT_INCR(@Tabla),1)
END
GO

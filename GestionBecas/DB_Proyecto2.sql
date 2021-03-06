USE [master]
GO
/****** Object:  Database [DB_Proyecto2]    Script Date: 11/17/2014 14:55:25 ******/
CREATE DATABASE [DB_Proyecto2] ON  PRIMARY 
( NAME = N'DB_Proyecto2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DB_Proyecto2.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_Proyecto2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DB_Proyecto2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_Proyecto2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Proyecto2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Proyecto2] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DB_Proyecto2] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DB_Proyecto2] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DB_Proyecto2] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DB_Proyecto2] SET ARITHABORT OFF
GO
ALTER DATABASE [DB_Proyecto2] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DB_Proyecto2] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DB_Proyecto2] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DB_Proyecto2] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DB_Proyecto2] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DB_Proyecto2] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DB_Proyecto2] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DB_Proyecto2] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DB_Proyecto2] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DB_Proyecto2] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DB_Proyecto2] SET  DISABLE_BROKER
GO
ALTER DATABASE [DB_Proyecto2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DB_Proyecto2] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DB_Proyecto2] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DB_Proyecto2] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DB_Proyecto2] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DB_Proyecto2] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DB_Proyecto2] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DB_Proyecto2] SET  READ_WRITE
GO
ALTER DATABASE [DB_Proyecto2] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DB_Proyecto2] SET  MULTI_USER
GO
ALTER DATABASE [DB_Proyecto2] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DB_Proyecto2] SET DB_CHAINING OFF
GO
USE [DB_Proyecto2]
GO

/****** Object:  Table [dbo].[Tb_TiposDeBeca]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_TiposDeBeca](
	[idTipoDeBeca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[Estado] [varchar](15) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Tipos__05FBDE8F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[idTipoDeBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Email]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Email](
	[IdEmail] [int] IDENTITY(1,1) NOT NULL,
	[Receptor] [varchar](50) NULL,
	[Emisor] [varchar](50) NOT NULL,
	[Asunto] [varchar](50) NULL,
	[SmtpServidor] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Mensaje] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_Email] ON
INSERT [dbo].[Tb_Email] ([IdEmail], [Receptor], [Emisor], [Asunto], [SmtpServidor], [UserName], [Contraseña], [Mensaje]) VALUES (1, N'alvartabe777@gmail.com', N'alvartabe777@gmail.com', N'Confirmación de cuenta', N'smtp.gmail.com', N'alvartabe777@gmail.com', N'androide1994', N'Mensaje de confirmación')
SET IDENTITY_INSERT [dbo].[Tb_Email] OFF
/****** Object:  Table [dbo].[Tb_Cursos]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Cursos](
	[Codigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cuatrimestre] [varchar](20) NOT NULL,
	[Creditos] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Curso__D68C8CB12A4B4B5E] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Permisos]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Permisos](
	[idPermiso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Permi__06A58486267ABA7A] PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_Permisos] ON
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (1, N'Roles', N'Todo lo relacionado con el módulo de roles', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (2, N'Usuarios', N'Todo lo relacionado con el módulo de usuarios', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (3, N'Carreras', N'Todo lo relacionado con las carreras', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (5, N'Cursos', N'Todo lo relacionado con cursos', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (6, N'Requisitos', N'Todo lo relacionado con requisitos', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (7, N'Beneficios', N'Todo lo relacionado con beneficios', 0)
INSERT [dbo].[Tb_Permisos] ([idPermiso], [Nombre], [Descripcion], [Eliminado]) VALUES (9, N'Becas', N'Todo lo relacionado con becas', 0)
SET IDENTITY_INSERT [dbo].[Tb_Permisos] OFF
/****** Object:  Table [dbo].[Tb_HistorialesAcademicos]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_HistorialesAcademicos](
	[IdHistorialAcademico] [int] IDENTITY(1,1) NOT NULL,
	[Nota] [decimal](3, 2) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Histo__1DE5DC31440B1D61] PRIMARY KEY CLUSTERED 
(
	[IdHistorialAcademico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Requisitos]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Requisitos](
	[idRequisito] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Requi__9A15459D75A278F5] PRIMARY KEY CLUSTERED 
(
	[idRequisito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Provincia]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Provincia](
	[idProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NOT NULL,
 CONSTRAINT [PK__Tb_Provi__5F9F113C07020F21] PRIMARY KEY CLUSTERED 
(
	[idProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Roles]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Roles](
	[Nombre] [varchar](50) NOT NULL,
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Roles__2A49584C0F975522] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_Roles] ON
INSERT [dbo].[Tb_Roles] ([Nombre], [IdRol], [Eliminado]) VALUES (N'Administrador', 1, 0)
SET IDENTITY_INSERT [dbo].[Tb_Roles] OFF
/****** Object:  Table [dbo].[Tb_BitacoraError]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_BitacoraError](
	[idBitacora] [int] IDENTITY(1,1) NOT NULL,
	[FechaDelError] [date] NOT NULL,
	[Error] [varchar](100) NOT NULL,
	[Usuario] [varchar](45) NOT NULL,
	[Rol] [varchar](45) NOT NULL,
 CONSTRAINT [PK__Tb_Bitác__C4C6306968487DD7] PRIMARY KEY CLUSTERED 
(
	[idBitacora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_BitacoraAccion]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_BitacoraAccion](
	[FechaAccion] [date] NOT NULL,
	[Accion] [varchar](45) NOT NULL,
	[Usuario] [varchar](45) NOT NULL,
	[Rol] [varchar](45) NOT NULL,
	[IdBitacoraAccion] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Tb_BitácoraAcción] PRIMARY KEY CLUSTERED 
(
	[IdBitacoraAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_Beneficios]    Script Date: 11/17/2014 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Beneficios](
	[idBeneficio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Porcentaje] [decimal](3, 2) NOT NULL,
	[Aplicabilidad] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Benef__00AAC26A2E1BDC42] PRIMARY KEY CLUSTERED 
(
	[idBeneficio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_eliminarTipoBeca]
	-- Add the parameters for the stored procedure here
	@nombre as varchar(20)
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Tb_TiposDeBeca 
	SET [Eliminado] = 1
	where Nombre = @nombre 
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_eliminarRol] 
	-- Add the parameters for the stored procedure here
	@IdRol as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		UPDATE [dbo].Tb_Roles
   SET [Eliminado] = 1
    WHERE IdRol = @IdRol

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarCurso]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_eliminarCurso] 
	-- Add the parameters for the stored procedure here
	@Codigo as varchar(20)
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		UPDATE [dbo].Tb_Cursos
   SET [Eliminado] = 1
    WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarRequisito]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_eliminarRequisito]
	-- Add the parameters for the stored procedure here
	@IdRequisito as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	update Tb_Requisitos set Eliminado = 1
	where idRequisito = @IdRequisito and Eliminado = 0

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_eliminarBeneficio]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	update [dbo].Tb_Beneficios
	Set	[Eliminado] = 1
	Where idBeneficio = @id

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarRol]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Tb_Roles
	where Nombre = @nombre and Eliminado = 0
	
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_crearRequisito]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_crearRequisito]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@descripcion varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Tb_Requisitos values (@nombre, @descripcion, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_crearCurso]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_crearCurso] 
	-- Add the parameters for the stored procedure here
	@Codigo as varchar(20),
	@Nombre as varchar(50),
	@Cuatrimestre as varchar(20),
	@Creditos as int,
	@Precio as float

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	insert into Tb_Cursos values(@Codigo,@Nombre,@Cuatrimestre,@Creditos,@Precio,0)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_crearBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_crearBeneficio] 
	-- Add the parameters for the stored procedure here
	@Nombre as varchar(50),
	@Porcentaje as decimal(3,2),
	@Aplicabilidad as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	insert into Tb_Beneficios values(@Nombre,@Porcentaje,@Aplicabilidad,0)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultaTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultaTipoBeca]

	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        *
	FROM            dbo.Tb_TiposDeBeca
	Where Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_modificarTipoBeca] 
	-- Add the parameters for the stored procedure here
	@id as int,
	@Nombre as varchar(20),
	@Estado as varchar(15),
	@Descripcion as varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].Tb_TiposDeBeca
   SET[Nombre] = @Nombre,
	  [Estado] = @Estado,
	  [Descripcion]= @Descripcion
    WHERE idTipoDeBeca = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_modificarRol] 
	-- Add the parameters for the stored procedure here
	@IdRol as int,
	@Nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].Tb_Roles
   SET Nombre = @Nombre
    WHERE IdRol = @IdRol 
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarRequisitos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_modificarRequisitos]

	
	@Nombre as varchar(50),
	@Descripcion as varchar(50),
	@IdRequisito as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	update Tb_Requisitos 
	set 
	 Nombre = @Nombre, 
     Descripcion = @Descripcion
	where idRequisito = @IdRequisito

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarEmail]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_modificarEmail]

	
	@Emisor as varchar(50),
	@Asunto as varchar(50),
	@SmtpServidor as varchar(50),
	@UserName as varchar(50),
	@Contrasenna as varchar (20),
	@Mensaje as varchar(100),
	@id as int

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	UPDATE Tb_Email 
	
	SET
	 
	 Emisor = @Emisor, 
     Asunto = @Asunto,
	 SmtpServidor = @SmtpServidor,
	 UserName= @UserName,
	 Contraseña=@Contrasenna,
	 Mensaje = @Mensaje

	WHERE IdEmail = @id

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarCursos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_modificarCursos]

	
	@Codigo as varchar(20),
	@Nombre as varchar(50),
	@Cuatrimestre as varchar(20),
	@Creditos as int,
	@Precio as float,
	@IdCurso as int

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	update Tb_Cursos 
	set 
	 Codigo = @Codigo, 
     Nombre = @Nombre,
	 Cuatrimestre = @Cuatrimestre,
	 Creditos=@Creditos,
	 Precio=@Precio 
	where IdCurso = @IdCurso

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_modificarBeneficio] 
	-- Add the parameters for the stored procedure here
	@Id as int,
	@Nombre as varchar(50),
	@Porcentaje as decimal(3,2),
	@Aplicabilidad as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].Tb_Beneficios
   SET[Nombre] = @Nombre,
	  [Porcentaje] = @Porcentaje,
      [Aplicabilidad] = @Aplicabilidad
    WHERE idBeneficio = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_listarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_listarRol]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdRol,Nombre
	from Tb_Roles
	where Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarBeneficios]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarBeneficios]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idBeneficio, Nombre, Porcentaje, Aplicabilidad
	FROM Tb_Beneficios
	where Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarBeneficioPorNombre]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE  [dbo].[Sp_buscarBeneficioPorNombre] 
	-- Add the parameters for the stored procedure here
	@Nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idBeneficio, Nombre, Porcentaje, Aplicabilidad
	from Tb_Beneficios
	where Nombre = @Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_agregarTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_agregarTipoBeca]
	@nombre As varchar(20),
	@fechaCreacion As date,
	@estado as varchar(15),
	@descripcion as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tb_TiposDeBeca values(@nombre,@fechaCreacion,@estado,@descripcion, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_agregarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_agregarRol]
	-- Add the parameters for the stored procedure here
	@Nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tb_Roles values(@Nombre,0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarCursos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarCursos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Codigo,Nombre,Cuatrimestre,Creditos,Precio,IdCurso
	FROM Tb_Cursos
	Where Eliminado=0 
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarCursoPorCuatrimestre]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarCursoPorCuatrimestre]
	-- Add the parameters for the stored procedure here
	@Cuatrimestre as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT Codigo, Nombre, Creditos, Precio, Cuatrimestre
	FROM Tb_Cursos
	where Cuatrimestre = @Cuatrimestre and Eliminado = 0
	
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarCuatrimestre]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Sp_buscarCuatrimestre]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT distinct Cuatrimestre  
	FROM Tb_Cursos
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRequisito]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarRequisito]

	@parametro as varchar(50)
	
AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT Nombre, Descripcion, IdRequisito FROM Tb_Requisitos where Nombre = @parametro or Descripcion = @parametro AND Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarUnCurso]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
	CREATE PROCEDURE [dbo].[Sp_buscarUnCurso]
	-- Add the parameters for the stored procedure here
	@parametro varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Codigo,Nombre,Cuatrimestre,Creditos,Precio,IdCurso
	FROM dbo.Tb_Cursos 
		 
	where Codigo = @parametro OR Nombre = @parametro AND Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarTipoBecaNombre]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_buscarTipoBecaNombre]
	-- Add the parameters for the stored procedure here
	@Nombre as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT idTipoDeBeca,Nombre,FechaCreacion,Estado,Descripcion
	from Tb_TiposDeBeca 
	where Nombre= @Nombre And Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRolPorId]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_buscarRolPorId]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	From Tb_Roles
	Where IdRol = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarBitacoraFecha]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_consultarBitacoraFecha]

AS
BEGIN

	SET NOCOUNT ON;
	Select * from dbo.Tb_BitacoraAccion where dbo.Tb_BitacoraAccion.FechaAccion = {fn curdate()}

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarBeneficio]
	-- Add the parameters for the stored procedure here
	
	@Nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Nombre, Porcentaje, Aplicabilidad
	from Tb_Beneficios
	where Nombre = @Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarPermisos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarPermisos] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT idPermiso,Nombre, Descripcion 
		from Tb_Permisos
		where Eliminado = 0
		
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarEmail]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarEmail]

AS

BEGIN

SET NOCOUNT ON;

	SELECT *
	FROM dbo.Tb_Email				
	
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarCursosPorCuatrimestre]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarCursosPorCuatrimestre]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT Cuatrimestre
	from Tb_Cursos
	where Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarRoles]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarRoles]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Nombre
	from Tb_Roles
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarRol] 
	-- Add the parameters for the stored procedure here
	@nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT Nombre 
		from Tb_Roles
		where Nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarRequisitos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarRequisitos]

AS 

BEGIN

	SET NOCOUNT ON;

	SELECT        idRequisito, Nombre, Descripcion
FROM            dbo.Tb_Requisitos where Eliminado = 0
END
GO
/****** Object:  Table [dbo].[Tb_RequisitosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_RequisitosTipoBeca](
	[IdTipoBecaRequisito] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito] [int] NOT NULL,
	[Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca] [int] NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Requi__1830F99B797309D9] PRIMARY KEY CLUSTERED 
(
	[IdTipoBecaRequisito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_RequisitosTipoBeca_Tb_Requisitos_idx] ON [dbo].[Tb_RequisitosTipoBeca] 
(
	[Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_RequisitosTipoBeca_Tb_TiposDeBeca_idx] ON [dbo].[Tb_RequisitosTipoBeca] 
(
	[Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_registrarAccion]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_registrarAccion]
	-- Add the parameters for the stored procedure here
	@FechaAccion as Date,
	@Accion as varchar(45),
	@UserName as varchar(45),
	@Rol as varchar(45)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Tb_BitacoraAccion values (@FechaAccion, @Accion, @UserName, @Rol)
END
GO
/****** Object:  Table [dbo].[Tb_Canton]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Canton](
	[idCanton] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NOT NULL,
	[Fk_Tb_Provincia_Tb_Canton_idProvincia] [int] NOT NULL,
 CONSTRAINT [PK__Tb_Canto__622851F26C190EBB] PRIMARY KEY CLUSTERED 
(
	[idCanton] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Canton_Tb_Provincia_idx] ON [dbo].[Tb_Canton] 
(
	[Fk_Tb_Provincia_Tb_Canton_idProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Personas]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Personas](
	[Identificacion] [varchar](50) NOT NULL,
	[PrimerNombre] [varchar](45) NOT NULL,
	[SegundoNombre] [varchar](45) NULL,
	[PrimerApellido] [varchar](45) NOT NULL,
	[SegundoApellido] [varchar](45) NULL,
	[Telefono] [varchar](12) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Genero] [int] NOT NULL,
	[CorreoElectronico] [varchar](50) NOT NULL,
	[Fk_Tb_Provincia_Tb_Personas_idProvincia] [int] NULL,
 CONSTRAINT [PK__Tb_Perso__B826A2940AD2A005] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Personas_Tb_Provincia1_idx] ON [dbo].[Tb_Personas] 
(
	[Fk_Tb_Provincia_Tb_Personas_idProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[Tb_Personas] ([Identificacion], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Telefono], [FechaNacimiento], [Genero], [CorreoElectronico], [Fk_Tb_Provincia_Tb_Personas_idProvincia]) VALUES (N'201540148', N'Gabriela', N'', N'Gutiérrez', N'Corrales', N'88554455', CAST(0x40170B00 AS Date), 2, N'backi-g@hotmail.com', NULL)
/****** Object:  Table [dbo].[Tb_RolesPermisos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_RolesPermisos](
	[Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso] [int] NOT NULL,
	[Fk_Tb_Roles_Tb_RolesPermisos_IdRol] [int] NOT NULL,
	[IdRolesPermisos] [int] IDENTITY(1,1) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Roles__AAB7C8255629CD9C] PRIMARY KEY CLUSTERED 
(
	[IdRolesPermisos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_RolesPermisos_Tb_Permisos_idx] ON [dbo].[Tb_RolesPermisos] 
(
	[Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tb_RolesPermisos] ON
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (1, 1, 66, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (2, 1, 67, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (3, 1, 68, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (5, 1, 69, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (6, 1, 70, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (7, 1, 71, 0)
INSERT [dbo].[Tb_RolesPermisos] ([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso], [Fk_Tb_Roles_Tb_RolesPermisos_IdRol], [IdRolesPermisos], [Eliminado]) VALUES (9, 1, 72, 0)
SET IDENTITY_INSERT [dbo].[Tb_RolesPermisos] OFF
/****** Object:  Table [dbo].[Tb_TipoBecaBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_TipoBecaBeneficio](
	[Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio] [int] NOT NULL,
	[Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca] [int] NOT NULL,
	[IdTipoBecaBeneficio] [int] IDENTITY(1,1) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK_Tb_TipoBecaBeneficio] PRIMARY KEY CLUSTERED 
(
	[IdTipoBecaBeneficio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_BecaBeneficio_Tb_Beneficios_idx] ON [dbo].[Tb_TipoBecaBeneficio] 
(
	[Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_BecaBeneficio_Tb_TiposDeBeca_idx] ON [dbo].[Tb_TipoBecaBeneficio] 
(
	[Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Usuarios]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Usuarios](
	[Contraseña] [varchar](100) NOT NULL,
	[Fk_Tb_Roles_Tb_Usuarios_IdRol] [int] NOT NULL,
	[Fk_Tb_Personas_Tb_Usuarios_Identicacion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Tb_Usuar__E97942631367E606] PRIMARY KEY CLUSTERED 
(
	[Fk_Tb_Personas_Tb_Usuarios_Identicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Usuarios_Tb_Personas1_idx] ON [dbo].[Tb_Usuarios] 
(
	[Fk_Tb_Personas_Tb_Usuarios_Identicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Usuarios_Tb_Roles1_idx] ON [dbo].[Tb_Usuarios] 
(
	[Fk_Tb_Roles_Tb_Usuarios_IdRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tb_Usuarios] ON
INSERT [dbo].[Tb_Usuarios] ([Contraseña], [Fk_Tb_Roles_Tb_Usuarios_IdRol], [Fk_Tb_Personas_Tb_Usuarios_Identicacion], [Eliminado], [id]) VALUES (N'f4nY5g3ZGgw=', 1, N'201540148', 0, 58)
SET IDENTITY_INSERT [dbo].[Tb_Usuarios] OFF
/****** Object:  Table [dbo].[Tb_Distrito]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Distrito](
	[idDistrito] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NOT NULL,
	[Fk_Tb_Canton_TbDistrito_idCanton] [int] NOT NULL,
 CONSTRAINT [PK__Tb_Distr__494092A870DDC3D8] PRIMARY KEY CLUSTERED 
(
	[idDistrito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Distrito_Tb_Canton_idx] ON [dbo].[Tb_Distrito] 
(
	[Fk_Tb_Canton_TbDistrito_idCanton] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_obtenerRequisitoTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_obtenerRequisitoTipoBeca]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito
	from Tb_RequisitosTipoBeca 
	where Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_obtenerBeneficiosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_obtenerBeneficiosTipoBeca]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio
	From Tb_TipoBecaBeneficio
	where Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarPermisosPorRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarPermisosPorRol] 
	-- Add the parameters for the stored procedure here
	@IdRol as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT idPermiso,Nombre,Descripcion 
		from Tb_Permisos P
		inner Join Tb_RolesPermisos RP ON P.idPermiso = RP.Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso
		where Rp.Fk_Tb_Roles_Tb_RolesPermisos_IdRol = @IdRol and RP.Eliminado = 0
		
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarBeneficiosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_buscarBeneficiosTipoBeca]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        dbo.Tb_Beneficios.Nombre, dbo.Tb_Beneficios.Porcentaje, dbo.Tb_Beneficios.idBeneficio, dbo.Tb_TipoBecaBeneficio.IdTipoBecaBeneficio
	FROM            dbo.Tb_Beneficios INNER JOIN
                         dbo.Tb_TipoBecaBeneficio ON dbo.Tb_Beneficios.idBeneficio = dbo.Tb_TipoBecaBeneficio.Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio INNER JOIN
                         dbo.Tb_TiposDeBeca ON dbo.Tb_TipoBecaBeneficio.Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca = dbo.Tb_TiposDeBeca.idTipoDeBeca
		WHERE dbo.Tb_TiposDeBeca.idTipoDeBeca=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarBeneficiosPorTipoDeBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_buscarBeneficiosPorTipoDeBeca] 
	-- Add the parameters for the stored procedure here
	
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select      *
	FROM            dbo.Tb_TiposDeBeca INNER JOIN
                         dbo.Tb_TipoBecaBeneficio ON dbo.Tb_TipoBecaBeneficio.Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio = dbo.Tb_TipoBecaBeneficio.Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio
	WHERE @id = Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio and dbo.Tb_TiposDeBeca.Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_AsignarPermisosAUnRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_AsignarPermisosAUnRol] 
	-- Add the parameters for the stored procedure here
	@IdRol as int,
	@IdPermiso as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		insert into Tb_RolesPermisos values(@IdPermiso,@IdRol,0)
		
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarPermisoAUnRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[eliminarPermisoAUnRol] 
	-- Add the parameters for the stored procedure here
	@IdRolPermiso as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		UPDATE [dbo].Tb_RolesPermisos
   SET [Eliminado] = 1
    WHERE IdRolesPermisos = @IdRolPermiso

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_insertarTipoBecaCompleto]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_insertarTipoBecaCompleto]
	-- Add the parameters for the stored procedure here
	@idBeneficio as int,
	@Nombre as varchar(20)
	


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idTipoBeca int
    -- Insert statements for procedure here

	select  @idTipoBeca= idTipoDeBeca
	from Tb_TiposDeBeca 
	where Nombre = @Nombre

	insert into Tb_TipoBecaBeneficio values(@idBeneficio, @idTipoBeca, 0)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_insertarRequisitoTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_insertarRequisitoTipoBeca]
	-- Add the parameters for the stored procedure here
	@idRequisito int,
	@Nombre as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idTipoBeca int
    -- Insert statements for procedure here
	select @idTipoBeca= idTipoDeBeca 
	from Tb_TiposDeBeca 
	where Nombre= @Nombre 

	insert into Tb_RequisitosTipoBeca values(@idRequisito, @idTipoBeca, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_insertarRequisitoTB]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_insertarRequisitoTB]
	-- Add the parameters for the stored procedure here
	@idRequisito as int,
	@idTipoBeca as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
    -- Insert statements for procedure here
	
	insert into Tb_RequisitosTipoBeca values(@idRequisito, @idTipoBeca, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarTipoBecaRequisito]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarTipoBecaRequisito] 
	-- Add the parameters for the stored procedure here
	@Nombre as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idTipoBeca int

    -- Insert statements for procedure here
	select @idTipoBeca= idTipoDeBeca 
	from Tb_TiposDeBeca 
	where Nombre= @Nombre 

	SELECT      dbo.Tb_Requisitos.idRequisito ,Tb_Requisitos.Nombre, Tb_Requisitos.Descripcion 
    FROM        dbo.Tb_RequisitosTipoBeca INNER JOIN
                         dbo.Tb_Requisitos ON dbo.Tb_RequisitosTipoBeca.Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito = dbo.Tb_Requisitos.idRequisito INNER JOIN
                         dbo.Tb_TiposDeBeca ON dbo.Tb_RequisitosTipoBeca.Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca = dbo.Tb_TiposDeBeca.idTipoDeBeca
						 where idTipoDeBeca = @idTipoBeca
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarTipoBecaBeneficios]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_consultarTipoBecaBeneficios]
	-- Add the parameters for the stored procedure here
	@nombre as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idTipoBeca int
	 
    -- Insert statements for procedure here
	select @idTipoBeca= idTipoDeBeca 
	from Tb_TiposDeBeca 
	where Nombre= @Nombre

SELECT        dbo.Tb_Beneficios.idBeneficio , dbo.Tb_Beneficios.Nombre,  dbo.Tb_Beneficios.Porcentaje ,  dbo.Tb_Beneficios.Aplicabilidad
FROM          dbo.Tb_TipoBecaBeneficio INNER JOIN
                         dbo.Tb_Beneficios ON dbo.Tb_TipoBecaBeneficio.Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio = dbo.Tb_Beneficios.idBeneficio  INNER JOIN
                         dbo.Tb_TiposDeBeca ON dbo.Tb_TipoBecaBeneficio.Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca = dbo.Tb_TiposDeBeca.idTipoDeBeca
						 where idTipoDeBeca = @idTipoBeca 
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarRolesPermisos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarRolesPermisos] 
	-- Add the parameters for the stored procedure here
	@IdPermiso as int,
	@IdRol as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT IdRolesPermisos
		from Tb_RolesPermisos
		where Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso = @IdPermiso and Fk_Tb_Roles_Tb_RolesPermisos_IdRol = @IdRol
		
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRequisitosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarRequisitosTipoBeca]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        dbo.Tb_Requisitos.idRequisito, dbo.Tb_Requisitos.Nombre, dbo.Tb_Requisitos.Descripcion
	FROM            dbo.Tb_TiposDeBeca INNER JOIN
                         dbo.Tb_RequisitosTipoBeca ON dbo.Tb_TiposDeBeca.idTipoDeBeca = dbo.Tb_RequisitosTipoBeca.Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca INNER JOIN
                         dbo.Tb_Requisitos ON dbo.Tb_RequisitosTipoBeca.Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito = dbo.Tb_Requisitos.idRequisito
	WHERE dbo.Tb_TiposDeBeca.idTipoDeBeca=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRequisitosAUnTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarRequisitosAUnTipoBeca]
	-- Add the parameters for the stored procedure here
	@idRequisito as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        *
	FROM            dbo.Tb_TiposDeBeca INNER JOIN
                         dbo.Tb_RequisitosTipoBeca ON dbo.Tb_TiposDeBeca.idTipoDeBeca = dbo.Tb_RequisitosTipoBeca.Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca 
	WHERE			@idRequisito = Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito and	tb_TiposDeBeca.Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarPermisoAUnRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_eliminarPermisoAUnRol] 
	-- Add the parameters for the stored procedure here
	@IdPermiso as int,
	@IdRol as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		UPDATE [dbo].Tb_RolesPermisos
   SET [Eliminado] = 1
    WHERE Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso = @IdPermiso and Fk_Tb_Roles_Tb_RolesPermisos_IdRol =  @IdRol 

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarBeneficiosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_eliminarBeneficiosTipoBeca]
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE from Tb_TipoBecaBeneficio where Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_eliminarRequisitosTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_eliminarRequisitosTipoBeca] 
	-- Add the parameters for the stored procedure here
	@id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE from Tb_RequisitosTipoBeca where Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca =@id
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_insertarBeneficiosTiposBeca]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_insertarBeneficiosTiposBeca]
	-- Add the parameters for the stored procedure here
	@idBeneficio as int,
	@idTipoBeca as varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @id int
	
	select @id = idTipoDeBeca 
	from Tb_TiposDeBeca
	where Nombre = @idTipoBeca
	

    -- Insert statements for procedure here
	insert into Tb_TipoBecaBeneficio values(@idBeneficio, @id, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_iniciarSesion]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_iniciarSesion]
	-- Add the parameters for the stored procedure here
	@nombreUsuario varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Tb_Personas 
		INNER JOIN dbo.Tb_Usuarios 
				ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
	where CorreoElectronico = @nombreUsuario AND Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_crearUsuario]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_crearUsuario]
	-- Add the parameters for the stored procedure here
	@nombre varchar(45),
    @segundoNombre varchar(45),
    @primerApellido varchar (45),
    @segundoApellido varchar(45),
    @identificacion varchar(50),
    @telefono varchar(12),
    @fechaNacimiento date,
    @rol varchar(20),
    @genero int,
    @correoElectronico varchar(50),
    @contraseña varchar (100)
    
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idRol as integer

    -- Insert statements for procedure here
	SELECT @idRol = IdRol
	from Tb_Roles
	where Nombre = @rol
	
	insert into Tb_Personas values (@identificacion,@nombre,  @segundoNombre , @primerApellido, @segundoApellido, @telefono, @fechaNacimiento , 
	 @genero,  @correoElectronico , null)
	 
	
	 
	 insert into Tb_Usuarios values ( @contraseña,@idRol, @identificacion, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_borrarUsuario]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_borrarUsuario]
	-- Add the parameters for the stored procedure here
	@identificacion varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    UPDATE  Tb_Usuarios
    SET Eliminado = 1
    FROM dbo.Tb_Personas 
				INNER JOIN dbo.Tb_Usuarios 
						ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
	WHERE Identificacion = @identificacion
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarDirectoresAcademicos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarDirectoresAcademicos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 

    -- Insert statements for procedure here
	SELECT  *
	FROM    dbo.Tb_Personas INNER JOIN
            dbo.Tb_Usuarios ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion INNER JOIN
            dbo.Tb_Roles ON dbo.Tb_Usuarios.Fk_Tb_Roles_Tb_Usuarios_IdRol = dbo.Tb_Roles.IdRol
	where   dbo.Tb_Roles.Nombre = 'Director Academico' or dbo.Tb_Roles.Nombre = 'Director Académico' and Tb_Roles.Eliminado = 0 and Tb_Usuarios.Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarUsuariosPorRol]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Sp_buscarUsuariosPorRol]
	-- Add the parameters for the stored procedure here
	@idRol int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Tb_Personas 
		INNER JOIN dbo.Tb_Usuarios 
				ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
	where Fk_Tb_Roles_Tb_Usuarios_IdRol = @idRol AND Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarUsuarios]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarUsuarios]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     *
	FROM dbo.Tb_Personas 
		INNER JOIN dbo.Tb_Usuarios 
				ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
				
	WHERE Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarUnUsuario]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarUnUsuario]
	-- Add the parameters for the stored procedure here
	@parametro varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Tb_Personas 
		INNER JOIN dbo.Tb_Usuarios 
				ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
	where Identificacion = @parametro OR PrimerNombre = @parametro AND Eliminado = 0
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarRolEstudiante]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_buscarRolEstudiante]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        dbo.Tb_Personas.Identificacion, dbo.Tb_Personas.PrimerNombre, dbo.Tb_Personas.SegundoNombre, dbo.Tb_Personas.PrimerApellido, dbo.Tb_Personas.SegundoApellido, dbo.Tb_Personas.Telefono, 
                         dbo.Tb_Personas.FechaNacimiento, dbo.Tb_Personas.Genero, dbo.Tb_Personas.CorreoElectronico, dbo.Tb_Usuarios.Contraseña, dbo.Tb_Usuarios.Fk_Tb_Roles_Tb_Usuarios_IdRol, dbo.Tb_Usuarios.id, 
                         dbo.Tb_Roles.Nombre, dbo.Tb_Roles.IdRol
FROM            dbo.Tb_Personas INNER JOIN
                         dbo.Tb_Usuarios ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion INNER JOIN
                         dbo.Tb_Roles ON dbo.Tb_Usuarios.Fk_Tb_Roles_Tb_Usuarios_IdRol = dbo.Tb_Roles.IdRol
where Tb_Roles.Nombre = 'Estudiante' and Tb_Usuarios.Eliminado = 0
END
GO
/****** Object:  Table [dbo].[Tb_Postulantes]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Postulantes](
	[Fk_Tb_Personas_Tb_Postulante_Identicacion] [varchar](50) NOT NULL,
	[Fk_Tb_Postulante_Tb_Usuario_Identificacion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
	[idPostulante] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Tb_Postu__D6C446051A14E395] PRIMARY KEY CLUSTERED 
(
	[Fk_Tb_Personas_Tb_Postulante_Identicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Postulantes_Tb_Personas_idx] ON [dbo].[Tb_Postulantes] 
(
	[Fk_Tb_Personas_Tb_Postulante_Identicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Postulantes_Tb_Usuarios_idx] ON [dbo].[Tb_Postulantes] 
(
	[Fk_Tb_Postulante_Tb_Usuario_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_HistorialCurso]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_HistorialCurso](
	[idHistorialCurso] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Tb_HistorialesAcademicos_TbCursos_IdHistorialAcademico] [int] NOT NULL,
	[Fk_Tb_Cursos_TbHistorialCurso_Codigo] [varchar](20) NOT NULL,
	[Fk_Tb_Usuario_Tb_HistorialCurso_Identificacion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Histo__9547CD1B5BE2A6F2] PRIMARY KEY CLUSTERED 
(
	[idHistorialCurso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_HistorialCurso_Tb_Cursos_idx] ON [dbo].[Tb_HistorialCurso] 
(
	[Fk_Tb_Cursos_TbHistorialCurso_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_HistorialCurso_Tb_HistorialesAcadémicos_idx] ON [dbo].[Tb_HistorialCurso] 
(
	[Fk_Tb_HistorialesAcademicos_TbCursos_IdHistorialAcademico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_HistorialCurso_Tb_Usuarios_idx] ON [dbo].[Tb_HistorialCurso] 
(
	[Fk_Tb_Usuario_Tb_HistorialCurso_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarUsuario]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_modificarUsuario] 
	-- Add the parameters for the stored procedure here
	@id varchar(50),
	@identificacion varchar(50),
	@nombre varchar(45),
	@segundoNombre varchar(45),
	@primerApellido varchar(45),
	@segundoApellido varchar(45),
	@telefono varchar(12),
	@fechaNacimiento date,
	@genero int,
	@correoElectronico varchar(50),
	@contraseña varchar(100),
	@rol varchar(20)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	declare @idRol as integer

    -- Insert statements for procedure here
	SELECT @idRol = IdRol
	from Tb_Roles
	where Nombre = @rol
    -- Insert statements for procedure here
	UPDATE Tb_Personas
	SET Identificacion = @identificacion, 
		PrimerNombre = @nombre,
		SegundoNombre = @segundoNombre,
		PrimerApellido = @primerApellido,
		SegundoApellido = @segundoApellido,
		Telefono = @telefono,
		FechaNacimiento = @fechaNacimiento,
		Genero = @genero,
		CorreoElectronico = @correoElectronico
	FROM dbo.Tb_Personas 
	INNER JOIN dbo.Tb_Usuarios 
			ON dbo.Tb_Personas.Identificacion = dbo.Tb_Usuarios.Fk_Tb_Personas_Tb_Usuarios_Identicacion
	WHERE id = @id
	
	UPDATE Tb_Usuarios
	SET contraseña = @contraseña,
		Fk_Tb_Roles_Tb_Usuarios_IdRol = @idRol
	WHERE id = @id
END
GO
/****** Object:  Table [dbo].[Tb_Carreras]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Carreras](
	[Codigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Color] [varchar](45) NOT NULL,
	[IdCarrera] [int] IDENTITY(1,1) NOT NULL,
	[Eliminado] [bit] NULL,
	[Fk_Tb_Carreras_Tb_Usuario_Identificacion] [varchar](50) NULL,
 CONSTRAINT [PK__Tb_Carre__D68C8CB103317E3D] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_CarreraCursos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_CarreraCursos](
	[Fk_Tb_Carreras_Tb_CarreraCursos_Codigo] [varchar](20) NOT NULL,
	[Fk_TbCursos_Tb_CarreraCursos_Codigo] [varchar](20) NOT NULL,
	[idCarreraCurso] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Tb_Carre__29AFF9D347DBAE45] PRIMARY KEY CLUSTERED 
(
	[idCarreraCurso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_CarreraCursos_Tb_Carreras_idx] ON [dbo].[Tb_CarreraCursos] 
(
	[Fk_Tb_Carreras_Tb_CarreraCursos_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_CarreraCursos_Tb_Cursos_idx] ON [dbo].[Tb_CarreraCursos] 
(
	[Fk_TbCursos_Tb_CarreraCursos_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_DatosFamiliares]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_DatosFamiliares](
	[idDatosFamiliares] [int] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [varchar](45) NOT NULL,
	[SegundoNombre] [varchar](45) NULL,
	[PrimerApellido] [varchar](45) NOT NULL,
	[SegundoApellido] [varchar](45) NULL,
	[Genero] [int] NOT NULL,
	[TipoIdentificacion] [int] NOT NULL,
	[Identificacion] [varchar](45) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[EstadoCivil] [int] NOT NULL,
	[CondicionDeEmpleado] [int] NOT NULL,
	[Ocupacion] [varchar](45) NOT NULL,
	[IngresoSalario] [decimal](10, 2) NOT NULL,
	[IngresoCuentaPropia] [decimal](10, 2) NOT NULL,
	[OtroIngreso] [decimal](10, 2) NOT NULL,
	[DeficitFisicoMentalSensorial] [int] NOT NULL,
	[TipoPension] [int] NOT NULL,
	[CondicionAsegurado] [int] NOT NULL,
	[CentroEnseñanza] [int] NOT NULL,
	[UltimoAñoAprobado] [varchar](45) NOT NULL,
	[CicloDeEnseñanza] [varchar](45) NOT NULL,
	[Fk_TbPostulante_Tb_DatosFamiliares_Identificacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Tb_Datos__48D62C0E7F2BE32F] PRIMARY KEY CLUSTERED 
(
	[idDatosFamiliares] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_DatosFamiliares_Tb_Postulantes_idx] ON [dbo].[Tb_DatosFamiliares] 
(
	[Fk_TbPostulante_Tb_DatosFamiliares_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Formularios]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Formularios](
	[NumeroEstudio] [int] IDENTITY(1,1) NOT NULL,
	[FechaEstudio] [date] NOT NULL,
	[TipoDeIdentificacion] [int] NOT NULL,
	[EstadoCivil] [int] NOT NULL,
	[Zona] [varchar](50) NOT NULL,
	[DirecciónExacta] [varchar](100) NOT NULL,
	[NumeroVivienda] [int] NOT NULL,
	[TipoDeRiesgo] [varchar](45) NOT NULL,
	[ParedesExteriores] [int] NOT NULL,
	[Piso] [int] NOT NULL,
	[Techo] [int] NOT NULL,
	[CieloRaso] [int] NOT NULL,
	[CantidadCuartos] [int] NOT NULL,
	[CantidadCamas] [int] NOT NULL,
	[CantidadBaños] [int] NOT NULL,
	[AguaPotable] [int] NOT NULL,
	[Electricidad] [int] NOT NULL,
	[Computadora] [int] NOT NULL,
	[CantidadDeComputadoras] [int] NULL,
	[Fk_Tb_Postulantes_Tb_Formularios_Identificacion] [varchar](50) NOT NULL,
	[Fk_Tb_Usuarios_Tb_Formulario_Identificacion] [varchar](50) NOT NULL,
	[Fk_Tb_Provincia_Tb_Formulario_idProvincia] [int] NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Formu__0354BDA132E0915F] PRIMARY KEY CLUSTERED 
(
	[NumeroEstudio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Formularios_Tb_Postulantes1_idx] ON [dbo].[Tb_Formularios] 
(
	[Fk_Tb_Postulantes_Tb_Formularios_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Formularios_Tb_Provincia1_idx] ON [dbo].[Tb_Formularios] 
(
	[Fk_Tb_Provincia_Tb_Formulario_idProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Formularios_Tb_Usuarios1_idx] ON [dbo].[Tb_Formularios] 
(
	[Fk_Tb_Usuarios_Tb_Formulario_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_consultarCarreras]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_consultarCarreras]

AS

BEGIN

SET NOCOUNT ON;

	SELECT Codigo, Nombre, Color, IdCarrera, Fk_Tb_Carreras_Tb_Usuario_Identificacion
	FROM dbo.Tb_Carreras				
	WHERE dbo.Tb_Carreras .Eliminado = 0
	
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_buscarCarrera]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_buscarCarrera]

	@parametro as varchar(50)
	
AS
BEGIN 

	SET NOCOUNT ON;
	
	SELECT Codigo, Nombre, Color, IdCarrera, Fk_Tb_Carreras_Tb_Usuario_Identificacion
	FROM dbo.Tb_Carreras

WHERE Tb_Carreras.Codigo = @parametro  OR Tb_Carreras.Nombre = @parametro and Tb_Carreras.Eliminado = 0

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_borrarCarrera]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Sp_borrarCarrera]
	-- Add the parameters for the stored procedure here
	@codigo varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    UPDATE  Tb_Carreras
    SET Eliminado = 1

    FROM dbo.Tb_Carreras 
			
	WHERE Codigo = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_agregarCarrera]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_agregarCarrera]

	@Codigo as varchar(20),
	@Nombre as varchar(50),
	@Color as varchar(50),
	@DirectorAcademico as int

AS
BEGIN
	
	SET NOCOUNT ON;
 
	insert into Tb_Carreras values (@Codigo, @Nombre, @Color,0,null)
	UPDATE [dbo].Tb_Carreras
	SET 
      Fk_Tb_Carreras_Tb_Usuario_Identificacion = @DirectorAcademico
	WHERE Codigo = @Codigo
	

END
GO
/****** Object:  Table [dbo].[Tb_Becas]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Becas](
	[IdBeca] [int] IDENTITY(1,1) NOT NULL,
	[PeriodoAsignacion] [date] NOT NULL,
	[PeriodoVigencia] [date] NOT NULL,
	[Estado] [varchar](15) NOT NULL,
	[Fk_Tb_TiposDeBeca_Tb_Becas_idTipoDeBeca] [int] NOT NULL,
	[Fk_Tb_Carreras_Tb_Becas_Codigo] [varchar](20) NOT NULL,
	[Fk_Tb_Postulantes_Tb_Becas_Identificacion] [varchar](50) NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Becas__23D228E01FCDBCEB] PRIMARY KEY CLUSTERED 
(
	[IdBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Becas_Tb_Carreras_idx] ON [dbo].[Tb_Becas] 
(
	[Fk_Tb_Carreras_Tb_Becas_Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Becas_Tb_Postulantes_idx] ON [dbo].[Tb_Becas] 
(
	[Fk_Tb_Postulantes_Tb_Becas_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Becas_Tb_TiposDeBeca_idx] ON [dbo].[Tb_Becas] 
(
	[Fk_Tb_TiposDeBeca_Tb_Becas_idTipoDeBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_modificarCarrera]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_modificarCarrera]

	@Nombre as varchar(50),
	@Codigo as varchar(20),
	@Color as varchar(50),
	@idCarrera as int,
	@DirectorAcademico as int

AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	
	UPDATE Tb_Carreras set Codigo = @Codigo, Nombre = @Nombre, Color = @Color,
	Fk_Tb_Carreras_Tb_Usuario_Identificacion = @DirectorAcademico where IdCarrera = @idCarrera

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_insertarCursoCarrera]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_insertarCursoCarrera]
	-- Add the parameters for the stored procedure here
	@idCurso as int,
	@Nombre as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	declare @idCarrera int

    -- Insert statements for procedure here
	select @idCarrera= IdCarrera 
	from Tb_Carreras 
	where Nombre= @Nombre 

	insert into Tb_CarreraCursos values(@idCurso, @idCarrera)
END
GO
/****** Object:  Table [dbo].[Tb_PlanesDeEstudio]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_PlanesDeEstudio](
	[idPlanDeEstudios] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Tb_CarreraCurso_Tb_PlanesEstudio_idCarreraCurso] [int] NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Plane__5CE790BE4E88ABD4] PRIMARY KEY CLUSTERED 
(
	[idPlanDeEstudios] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_PlanesDeEstudio_Tb_CarreraCursos_idx] ON [dbo].[Tb_PlanesDeEstudio] 
(
	[Fk_Tb_CarreraCurso_Tb_PlanesEstudio_idCarreraCurso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Solicitudes]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_Solicitudes](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [int] NOT NULL,
	[Fk_Tb_Postulantes_Tb_Solicitudes_Identificacion] [varchar](50) NOT NULL,
	[Fk_Tb_Formularios_Tb_Solicitud_NumeroEstudio] [int] NOT NULL,
	[Eliminado] [bit] NULL,
 CONSTRAINT [PK__Tb_Solic__36899CEF398D8EEE] PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Solicitudes_Tb_Formularios1_idx] ON [dbo].[Tb_Solicitudes] 
(
	[Fk_Tb_Formularios_Tb_Solicitud_NumeroEstudio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_Solicitudes_Tb_Postulantes1_idx] ON [dbo].[Tb_Solicitudes] 
(
	[Fk_Tb_Postulantes_Tb_Solicitudes_Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_DocumentosAdjuntos]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_DocumentosAdjuntos](
	[idDocumentosAdjuntos] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Fk_Tb_Solicitudes_Tb_DocumentosAdjuntos_IdSolicitud] [int] NOT NULL,
 CONSTRAINT [PK__Tb_Docum__F2F5FB713F466844] PRIMARY KEY CLUSTERED 
(
	[idDocumentosAdjuntos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_DocumentosAdjuntos_Tb_Solicitudes_idx] ON [dbo].[Tb_DocumentosAdjuntos] 
(
	[Fk_Tb_Solicitudes_Tb_DocumentosAdjuntos_IdSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_FlujoDeAprobacion]    Script Date: 11/17/2014 14:55:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_FlujoDeAprobacion](
	[idFlujoDeAprobacion] [int] IDENTITY(1,1) NOT NULL,
	[Fk_Tb_Usuarios_Tb_FlujoAprobacion_IdIdentificacion] [varchar](50) NOT NULL,
	[Fk_Tb_Solicitudes_Tb_FlujoDeAprobacion_IdSolicitud] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Estado] [int] NOT NULL,
	[Justificacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Tb_Flujo__28C31889628FA481] PRIMARY KEY CLUSTERED 
(
	[idFlujoDeAprobacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [fk_Tb_FlujoDeAprobación_Tb_Solicitudes_idx] ON [dbo].[Tb_FlujoDeAprobacion] 
(
	[Fk_Tb_Solicitudes_Tb_FlujoDeAprobacion_IdSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [fk_Tb_FlujoDeAprobación_Tb_Usuarios_idx] ON [dbo].[Tb_FlujoDeAprobacion] 
(
	[Fk_Tb_Usuarios_Tb_FlujoAprobacion_IdIdentificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [fk_Tb_RequisitosTipoBeca_Tb_Requisitos]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_RequisitosTipoBeca]  WITH CHECK ADD  CONSTRAINT [fk_Tb_RequisitosTipoBeca_Tb_Requisitos] FOREIGN KEY([Fk_Tb_Requisitos_Tb_RequisitosTipoBeca_idRequisito])
REFERENCES [dbo].[Tb_Requisitos] ([idRequisito])
GO
ALTER TABLE [dbo].[Tb_RequisitosTipoBeca] CHECK CONSTRAINT [fk_Tb_RequisitosTipoBeca_Tb_Requisitos]
GO
/****** Object:  ForeignKey [fk_Tb_RequisitosTipoBeca_Tb_TiposDeBeca]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_RequisitosTipoBeca]  WITH CHECK ADD  CONSTRAINT [fk_Tb_RequisitosTipoBeca_Tb_TiposDeBeca] FOREIGN KEY([Fk_Tb_TiposDeBeca_Tb_RequisitosTipoBeca_idTipoDeBeca])
REFERENCES [dbo].[Tb_TiposDeBeca] ([idTipoDeBeca])
GO
ALTER TABLE [dbo].[Tb_RequisitosTipoBeca] CHECK CONSTRAINT [fk_Tb_RequisitosTipoBeca_Tb_TiposDeBeca]
GO
/****** Object:  ForeignKey [fk_Tb_Canton_Tb_Provincia]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Canton]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Canton_Tb_Provincia] FOREIGN KEY([Fk_Tb_Provincia_Tb_Canton_idProvincia])
REFERENCES [dbo].[Tb_Provincia] ([idProvincia])
GO
ALTER TABLE [dbo].[Tb_Canton] CHECK CONSTRAINT [fk_Tb_Canton_Tb_Provincia]
GO
/****** Object:  ForeignKey [fk_Tb_Personas_Tb_Provincia1]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Personas]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Personas_Tb_Provincia1] FOREIGN KEY([Fk_Tb_Provincia_Tb_Personas_idProvincia])
REFERENCES [dbo].[Tb_Provincia] ([idProvincia])
GO
ALTER TABLE [dbo].[Tb_Personas] CHECK CONSTRAINT [fk_Tb_Personas_Tb_Provincia1]
GO
/****** Object:  ForeignKey [fk_Tb_RolesPermisos_Tb_Permisos]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_RolesPermisos]  WITH CHECK ADD  CONSTRAINT [fk_Tb_RolesPermisos_Tb_Permisos] FOREIGN KEY([Fk_Tb_Permisos_Tb_Rolespermisos_idPermiso])
REFERENCES [dbo].[Tb_Permisos] ([idPermiso])
GO
ALTER TABLE [dbo].[Tb_RolesPermisos] CHECK CONSTRAINT [fk_Tb_RolesPermisos_Tb_Permisos]
GO
/****** Object:  ForeignKey [fk_Tb_RolesPermisos_Tb_Roles]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_RolesPermisos]  WITH CHECK ADD  CONSTRAINT [fk_Tb_RolesPermisos_Tb_Roles] FOREIGN KEY([Fk_Tb_Roles_Tb_RolesPermisos_IdRol])
REFERENCES [dbo].[Tb_Roles] ([IdRol])
GO
ALTER TABLE [dbo].[Tb_RolesPermisos] CHECK CONSTRAINT [fk_Tb_RolesPermisos_Tb_Roles]
GO
/****** Object:  ForeignKey [FK_Tb_TipoBecaBeneficio_Tb_Beneficio_IdBeneficio]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_TipoBecaBeneficio]  WITH CHECK ADD  CONSTRAINT [FK_Tb_TipoBecaBeneficio_Tb_Beneficio_IdBeneficio] FOREIGN KEY([Fk_Tb_Beneficios_Tb_BecaBeneficios_idBeneficio])
REFERENCES [dbo].[Tb_Beneficios] ([idBeneficio])
GO
ALTER TABLE [dbo].[Tb_TipoBecaBeneficio] CHECK CONSTRAINT [FK_Tb_TipoBecaBeneficio_Tb_Beneficio_IdBeneficio]
GO
/****** Object:  ForeignKey [FK_Tb_TipoBecaBeneficio_Tb_TipoBeca_IdTipoBeca]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_TipoBecaBeneficio]  WITH CHECK ADD  CONSTRAINT [FK_Tb_TipoBecaBeneficio_Tb_TipoBeca_IdTipoBeca] FOREIGN KEY([Fk_Tb_TiposDeBeca_Tb_TipoBecaBeneficio_idTipoDeBeca])
REFERENCES [dbo].[Tb_TiposDeBeca] ([idTipoDeBeca])
GO
ALTER TABLE [dbo].[Tb_TipoBecaBeneficio] CHECK CONSTRAINT [FK_Tb_TipoBecaBeneficio_Tb_TipoBeca_IdTipoBeca]
GO
/****** Object:  ForeignKey [fk_Tb_Usuarios_Tb_Personas]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Usuarios_Tb_Personas] FOREIGN KEY([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
REFERENCES [dbo].[Tb_Personas] ([Identificacion])
GO
ALTER TABLE [dbo].[Tb_Usuarios] CHECK CONSTRAINT [fk_Tb_Usuarios_Tb_Personas]
GO
/****** Object:  ForeignKey [fk_Tb_Usuarios_Tb_Roles]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Usuarios_Tb_Roles] FOREIGN KEY([Fk_Tb_Roles_Tb_Usuarios_IdRol])
REFERENCES [dbo].[Tb_Roles] ([IdRol])
GO
ALTER TABLE [dbo].[Tb_Usuarios] CHECK CONSTRAINT [fk_Tb_Usuarios_Tb_Roles]
GO
/****** Object:  ForeignKey [fk_Tb_Distrito_Tb_Canton]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Distrito]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Distrito_Tb_Canton] FOREIGN KEY([Fk_Tb_Canton_TbDistrito_idCanton])
REFERENCES [dbo].[Tb_Canton] ([idCanton])
GO
ALTER TABLE [dbo].[Tb_Distrito] CHECK CONSTRAINT [fk_Tb_Distrito_Tb_Canton]
GO
/****** Object:  ForeignKey [fk_Tb_Postulantes_Tb_Personas]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Postulantes]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Postulantes_Tb_Personas] FOREIGN KEY([Fk_Tb_Personas_Tb_Postulante_Identicacion])
REFERENCES [dbo].[Tb_Personas] ([Identificacion])
GO
ALTER TABLE [dbo].[Tb_Postulantes] CHECK CONSTRAINT [fk_Tb_Postulantes_Tb_Personas]
GO
/****** Object:  ForeignKey [fk_Tb_Postulantes_Tb_Usuarios]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Postulantes]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Postulantes_Tb_Usuarios] FOREIGN KEY([Fk_Tb_Postulante_Tb_Usuario_Identificacion])
REFERENCES [dbo].[Tb_Usuarios] ([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Postulantes] CHECK CONSTRAINT [fk_Tb_Postulantes_Tb_Usuarios]
GO
/****** Object:  ForeignKey [fk_Tb_HistorialCurso_Tb_Cursos]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_HistorialCurso]  WITH CHECK ADD  CONSTRAINT [fk_Tb_HistorialCurso_Tb_Cursos] FOREIGN KEY([Fk_Tb_Cursos_TbHistorialCurso_Codigo])
REFERENCES [dbo].[Tb_Cursos] ([Codigo])
GO
ALTER TABLE [dbo].[Tb_HistorialCurso] CHECK CONSTRAINT [fk_Tb_HistorialCurso_Tb_Cursos]
GO
/****** Object:  ForeignKey [fk_Tb_HistorialCurso_Tb_HistorialesAcadémicos]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_HistorialCurso]  WITH CHECK ADD  CONSTRAINT [fk_Tb_HistorialCurso_Tb_HistorialesAcadémicos] FOREIGN KEY([Fk_Tb_HistorialesAcademicos_TbCursos_IdHistorialAcademico])
REFERENCES [dbo].[Tb_HistorialesAcademicos] ([IdHistorialAcademico])
GO
ALTER TABLE [dbo].[Tb_HistorialCurso] CHECK CONSTRAINT [fk_Tb_HistorialCurso_Tb_HistorialesAcadémicos]
GO
/****** Object:  ForeignKey [fk_Tb_HistorialCurso_Tb_Usuarios]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_HistorialCurso]  WITH CHECK ADD  CONSTRAINT [fk_Tb_HistorialCurso_Tb_Usuarios] FOREIGN KEY([Fk_Tb_Usuario_Tb_HistorialCurso_Identificacion])
REFERENCES [dbo].[Tb_Usuarios] ([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
GO
ALTER TABLE [dbo].[Tb_HistorialCurso] CHECK CONSTRAINT [fk_Tb_HistorialCurso_Tb_Usuarios]
GO
/****** Object:  ForeignKey [Fk_Tb_Carreras_Tb_Usuarios_Identificacion]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Carreras]  WITH CHECK ADD  CONSTRAINT [Fk_Tb_Carreras_Tb_Usuarios_Identificacion] FOREIGN KEY([Fk_Tb_Carreras_Tb_Usuario_Identificacion])
REFERENCES [dbo].[Tb_Usuarios] ([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Carreras] CHECK CONSTRAINT [Fk_Tb_Carreras_Tb_Usuarios_Identificacion]
GO
/****** Object:  ForeignKey [fk_Tb_CarreraCursos_Tb_Carreras_Codigo]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_CarreraCursos]  WITH CHECK ADD  CONSTRAINT [fk_Tb_CarreraCursos_Tb_Carreras_Codigo] FOREIGN KEY([Fk_Tb_Carreras_Tb_CarreraCursos_Codigo])
REFERENCES [dbo].[Tb_Carreras] ([Codigo])
GO
ALTER TABLE [dbo].[Tb_CarreraCursos] CHECK CONSTRAINT [fk_Tb_CarreraCursos_Tb_Carreras_Codigo]
GO
/****** Object:  ForeignKey [fk_Tb_CarreraCursos_Tb_Cursos_Codigo]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_CarreraCursos]  WITH CHECK ADD  CONSTRAINT [fk_Tb_CarreraCursos_Tb_Cursos_Codigo] FOREIGN KEY([Fk_TbCursos_Tb_CarreraCursos_Codigo])
REFERENCES [dbo].[Tb_Cursos] ([Codigo])
GO
ALTER TABLE [dbo].[Tb_CarreraCursos] CHECK CONSTRAINT [fk_Tb_CarreraCursos_Tb_Cursos_Codigo]
GO
/****** Object:  ForeignKey [fk_Tb_DatosFamiliares_Tb_Postulantes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_DatosFamiliares]  WITH CHECK ADD  CONSTRAINT [fk_Tb_DatosFamiliares_Tb_Postulantes] FOREIGN KEY([Fk_TbPostulante_Tb_DatosFamiliares_Identificacion])
REFERENCES [dbo].[Tb_Postulantes] ([Fk_Tb_Personas_Tb_Postulante_Identicacion])
GO
ALTER TABLE [dbo].[Tb_DatosFamiliares] CHECK CONSTRAINT [fk_Tb_DatosFamiliares_Tb_Postulantes]
GO
/****** Object:  ForeignKey [fk_Tb_Formularios_Tb_Postulantes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Formularios]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Formularios_Tb_Postulantes] FOREIGN KEY([Fk_Tb_Postulantes_Tb_Formularios_Identificacion])
REFERENCES [dbo].[Tb_Postulantes] ([Fk_Tb_Personas_Tb_Postulante_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Formularios] CHECK CONSTRAINT [fk_Tb_Formularios_Tb_Postulantes]
GO
/****** Object:  ForeignKey [fk_Tb_Formularios_Tb_Provincia]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Formularios]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Formularios_Tb_Provincia] FOREIGN KEY([Fk_Tb_Provincia_Tb_Formulario_idProvincia])
REFERENCES [dbo].[Tb_Provincia] ([idProvincia])
GO
ALTER TABLE [dbo].[Tb_Formularios] CHECK CONSTRAINT [fk_Tb_Formularios_Tb_Provincia]
GO
/****** Object:  ForeignKey [fk_Tb_Formularios_Tb_Usuarios]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Formularios]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Formularios_Tb_Usuarios] FOREIGN KEY([Fk_Tb_Usuarios_Tb_Formulario_Identificacion])
REFERENCES [dbo].[Tb_Usuarios] ([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Formularios] CHECK CONSTRAINT [fk_Tb_Formularios_Tb_Usuarios]
GO
/****** Object:  ForeignKey [fk_Tb_Becas_Tb_Carreras]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Becas]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Becas_Tb_Carreras] FOREIGN KEY([Fk_Tb_Carreras_Tb_Becas_Codigo])
REFERENCES [dbo].[Tb_Carreras] ([Codigo])
GO
ALTER TABLE [dbo].[Tb_Becas] CHECK CONSTRAINT [fk_Tb_Becas_Tb_Carreras]
GO
/****** Object:  ForeignKey [fk_Tb_Becas_Tb_Postulantes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Becas]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Becas_Tb_Postulantes] FOREIGN KEY([Fk_Tb_Postulantes_Tb_Becas_Identificacion])
REFERENCES [dbo].[Tb_Postulantes] ([Fk_Tb_Personas_Tb_Postulante_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Becas] CHECK CONSTRAINT [fk_Tb_Becas_Tb_Postulantes]
GO
/****** Object:  ForeignKey [fk_Tb_Becas_Tb_TiposDeBeca]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Becas]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Becas_Tb_TiposDeBeca] FOREIGN KEY([Fk_Tb_TiposDeBeca_Tb_Becas_idTipoDeBeca])
REFERENCES [dbo].[Tb_TiposDeBeca] ([idTipoDeBeca])
GO
ALTER TABLE [dbo].[Tb_Becas] CHECK CONSTRAINT [fk_Tb_Becas_Tb_TiposDeBeca]
GO
/****** Object:  ForeignKey [fk_Tb_PlanesDeEstudio_Tb_CarreraCursos]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_PlanesDeEstudio]  WITH CHECK ADD  CONSTRAINT [fk_Tb_PlanesDeEstudio_Tb_CarreraCursos] FOREIGN KEY([Fk_Tb_CarreraCurso_Tb_PlanesEstudio_idCarreraCurso])
REFERENCES [dbo].[Tb_CarreraCursos] ([idCarreraCurso])
GO
ALTER TABLE [dbo].[Tb_PlanesDeEstudio] CHECK CONSTRAINT [fk_Tb_PlanesDeEstudio_Tb_CarreraCursos]
GO
/****** Object:  ForeignKey [fk_Tb_Solicitudes_Tb_Formularios]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Solicitudes]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Solicitudes_Tb_Formularios] FOREIGN KEY([Fk_Tb_Formularios_Tb_Solicitud_NumeroEstudio])
REFERENCES [dbo].[Tb_Formularios] ([NumeroEstudio])
GO
ALTER TABLE [dbo].[Tb_Solicitudes] CHECK CONSTRAINT [fk_Tb_Solicitudes_Tb_Formularios]
GO
/****** Object:  ForeignKey [fk_Tb_Solicitudes_Tb_Postulantes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_Solicitudes]  WITH CHECK ADD  CONSTRAINT [fk_Tb_Solicitudes_Tb_Postulantes] FOREIGN KEY([Fk_Tb_Postulantes_Tb_Solicitudes_Identificacion])
REFERENCES [dbo].[Tb_Postulantes] ([Fk_Tb_Personas_Tb_Postulante_Identicacion])
GO
ALTER TABLE [dbo].[Tb_Solicitudes] CHECK CONSTRAINT [fk_Tb_Solicitudes_Tb_Postulantes]
GO
/****** Object:  ForeignKey [fk_Tb_DocumentosAdjuntos_Tb_Solicitudes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_DocumentosAdjuntos]  WITH CHECK ADD  CONSTRAINT [fk_Tb_DocumentosAdjuntos_Tb_Solicitudes] FOREIGN KEY([Fk_Tb_Solicitudes_Tb_DocumentosAdjuntos_IdSolicitud])
REFERENCES [dbo].[Tb_Solicitudes] ([IdSolicitud])
GO
ALTER TABLE [dbo].[Tb_DocumentosAdjuntos] CHECK CONSTRAINT [fk_Tb_DocumentosAdjuntos_Tb_Solicitudes]
GO
/****** Object:  ForeignKey [fk_Tb_FlujoDeAprobación_Tb_Solicitudes]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_FlujoDeAprobacion]  WITH CHECK ADD  CONSTRAINT [fk_Tb_FlujoDeAprobación_Tb_Solicitudes] FOREIGN KEY([Fk_Tb_Solicitudes_Tb_FlujoDeAprobacion_IdSolicitud])
REFERENCES [dbo].[Tb_Solicitudes] ([IdSolicitud])
GO
ALTER TABLE [dbo].[Tb_FlujoDeAprobacion] CHECK CONSTRAINT [fk_Tb_FlujoDeAprobación_Tb_Solicitudes]
GO
/****** Object:  ForeignKey [fk_Tb_FlujoDeAprobación_Tb_Usuarios]    Script Date: 11/17/2014 14:55:27 ******/
ALTER TABLE [dbo].[Tb_FlujoDeAprobacion]  WITH CHECK ADD  CONSTRAINT [fk_Tb_FlujoDeAprobación_Tb_Usuarios] FOREIGN KEY([Fk_Tb_Usuarios_Tb_FlujoAprobacion_IdIdentificacion])
REFERENCES [dbo].[Tb_Usuarios] ([Fk_Tb_Personas_Tb_Usuarios_Identicacion])
GO
ALTER TABLE [dbo].[Tb_FlujoDeAprobacion] CHECK CONSTRAINT [fk_Tb_FlujoDeAprobación_Tb_Usuarios]
GO

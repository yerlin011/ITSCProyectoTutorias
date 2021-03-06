USE [master]
GO
IF EXISTS (Select name from sys.databases where name = N'BD_Registro_Tutorias')
	ALTER DATABASE [BD_Registro_Tutorias] set single_user WITH rollback IMMEDIATE
go
	
IF EXISTS (Select name from sys.databases where name = N'BD_Registro_Tutorias')
	DROP DATABASE [BD_Registro_Tutorias]
GO
/****** Object:  Database [BD_Registro_Tutorias]    Script Date: 8/18/2018 2:08:59 PM ******/
CREATE DATABASE [BD_Registro_Tutorias]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Registro_Tutorias', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BD_Registro_Tutorias.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_Registro_Tutorias_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BD_Registro_Tutorias_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD_Registro_Tutorias] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Registro_Tutorias].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Registro_Tutorias] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BD_Registro_Tutorias] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BD_Registro_Tutorias]
GO
/****** Object:  User [User]    Script Date: 8/18/2018 2:09:05 PM ******/
CREATE USER [User] FOR LOGIN [User]
GO
/****** Object:  Table [dbo].[ASIGNAR_TUTORIA]    Script Date: 8/18/2018 2:09:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASIGNAR_TUTORIA](
	[Id_AsignarTutoria] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [int] NULL,
	[Materia] [int] NULL,
	[Ciclo] [int] NULL,
 CONSTRAINT [PK_ASIGNAR_TUTORIA] PRIMARY KEY CLUSTERED 
(
	[Id_AsignarTutoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ASISTENCIA]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASISTENCIA](
	[Id_Asistencia] [int] IDENTITY(1,1) NOT NULL,
	[CodEstudiante] [int] NULL,
	[CodTutorias] [int] NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_ASISTENCIA] PRIMARY KEY CLUSTERED 
(
	[Id_Asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CARRERA]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARRERA](
	[Id_Carrera] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Carrera] [nvarchar](100) NULL,
 CONSTRAINT [PK_CARRERA] PRIMARY KEY CLUSTERED 
(
	[Id_Carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CICLO]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CICLO](
	[Id_Ciclo] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Inicio] [datetime] NULL,
	[Fecha_Termino] [datetime] NULL,
	[Periodo] [nvarchar](50) NULL,
 CONSTRAINT [PK_CICLO] PRIMARY KEY CLUSTERED 
(
	[Id_Ciclo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CREAR_TUTORIA]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CREAR_TUTORIA](
	[Id_Tutoria] [int] IDENTITY(1,1) NOT NULL,
	[Codigos_Asignatura] [int] NULL,
	[Codigos_Maestro] [int] NULL,
	[Codigos_Dias] [int] NULL,
	[Codigos_Horas] [int] NULL,
	[Codigos_Ciclo] [int] NULL,
 CONSTRAINT [PK_CREAR_TUTORIA] PRIMARY KEY CLUSTERED 
(
	[Id_Tutoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DIAS]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIAS](
	[Id_Dias] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Dias] [nvarchar](100) NULL,
 CONSTRAINT [PK_DIAS] PRIMARY KEY CLUSTERED 
(
	[Id_Dias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ESTUDIANTE]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTUDIANTE](
	[Id_Estudiante] [int] IDENTITY(1,1) NOT NULL,
	[Matricula_Estudiante] [nvarchar](100) NULL,
	[Nombre_Estudiante] [nvarchar](100) NULL,
	[Apellido_Estudiante] [nvarchar](100) NULL,
	[Codigos_Carrera] [int] NULL,
	[Telefono] [nvarchar](100) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_ESTUDIANTE] PRIMARY KEY CLUSTERED 
(
	[Id_Estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HORARIO]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORARIO](
	[Id_Horario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Horario] [nvarchar](100) NULL,
 CONSTRAINT [PK_HORARIO] PRIMARY KEY CLUSTERED 
(
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HORARIOS]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORARIOS](
	[Id_Horario] [int] IDENTITY(1,1) NOT NULL,
	[Dias] [nvarchar](100) NULL,
	[Horas] [nvarchar](100) NULL,
 CONSTRAINT [PK_HORARIOS] PRIMARY KEY CLUSTERED 
(
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAESTRO]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAESTRO](
	[Id_Maestro] [int] IDENTITY(1,1) NOT NULL,
	[Codigos_Maestro] [nvarchar](100) NULL,
	[Nombre_Maestro] [nvarchar](100) NULL,
	[Departamento_Maestro] [nvarchar](100) NULL,
	[Correo] [nvarchar](100) NULL,
	[Telefono] [nvarchar](100) NULL,
 CONSTRAINT [PK_MAESTRO] PRIMARY KEY CLUSTERED 
(
	[Id_Maestro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAESTRO_MATERIA]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAESTRO_MATERIA](
	[Id_MaestroMateria] [int] IDENTITY(1,1) NOT NULL,
	[Maestro] [int] NULL,
	[Materia] [int] NULL,
 CONSTRAINT [PK_MAESTRO_MATERIA] PRIMARY KEY CLUSTERED 
(
	[Id_MaestroMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MATERIA]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIA](
	[Id_Materia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Materia] [nvarchar](100) NULL,
 CONSTRAINT [PK_MATERIA] PRIMARY KEY CLUSTERED 
(
	[Id_Materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/18/2018 2:09:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [nvarchar](50) NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Cargo] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ASIGNAR_TUTORIA] ON 

GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (1, 4, 3, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (2, 1, 4, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (3, 3, 5, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (4, 2, 8, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (5, 5, 1, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (6, 6, 4, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (7, 7, 1, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (8, 8, 1, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (9, 6, 1, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (10, 9, 1, 1)
GO
INSERT [dbo].[ASIGNAR_TUTORIA] ([Id_AsignarTutoria], [Matricula], [Materia], [Ciclo]) VALUES (11, 9, 8, 1)
GO
SET IDENTITY_INSERT [dbo].[ASIGNAR_TUTORIA] OFF
GO
SET IDENTITY_INSERT [dbo].[ASISTENCIA] ON 

GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (1, 1, 1, CAST(N'2018-07-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2, 2, 2, CAST(N'2018-07-10 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (3, 3, 3, CAST(N'2018-08-10 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (5, 5, 3, CAST(N'2018-09-07 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (6, 2, 3, CAST(N'2018-08-10 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (1004, 4, 1004, CAST(N'2018-07-08 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (1005, 1, 1004, CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2002, 6, 1004, CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2003, 7, 2, CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2004, 6, 1, CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2005, 9, 1, CAST(N'2018-08-12 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ASISTENCIA] ([Id_Asistencia], [CodEstudiante], [CodTutorias], [Fecha]) VALUES (2006, 9, 1005, CAST(N'2018-08-12 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ASISTENCIA] OFF
GO
SET IDENTITY_INSERT [dbo].[CARRERA] ON 

GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (1, N'Desarrollo de software')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (2, N'Administracion de Redes')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (3, N'Soporte Tecnico')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (4, N'Diseño Grafico')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (5, N'Diseño Interiores')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (6, N'Tecnico Electricidad')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (7, N'Tecnico Electronico')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (8, N'Tecnico Refrigeracion')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (9, N'Tecnico Construccion')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (10, N'Tecnico Logistica')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (11, N'Gastronomia')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (12, N'Panaderia y reposteria')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (13, N'Enfermeria')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (14, N'Imagenes Medicas')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (15, N'Mecanica Automotriz')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (16, N'Mecanica Dental')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (17, N'Diseño de Modas')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (18, N'Higiene Dental')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (19, N'Tecnico Manufactura')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (20, N'Industria del mueble')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (21, N'Fotografia')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (22, N'Produccion de eventos')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (23, N'Gestion alojamiento Turistico')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (24, N'Alimentos y Bebidas')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (25, N'Intermediacion Turisticas')
GO
INSERT [dbo].[CARRERA] ([Id_Carrera], [Nombre_Carrera]) VALUES (26, N'Sistema de Informacion Turisticas')
GO
SET IDENTITY_INSERT [dbo].[CARRERA] OFF
GO
SET IDENTITY_INSERT [dbo].[CICLO] ON 

GO
INSERT [dbo].[CICLO] ([Id_Ciclo], [Fecha_Inicio], [Fecha_Termino], [Periodo]) VALUES (1, CAST(N'2018-04-28 00:00:00.000' AS DateTime), CAST(N'2018-07-28 00:00:00.000' AS DateTime), N'2018-2')
GO
INSERT [dbo].[CICLO] ([Id_Ciclo], [Fecha_Inicio], [Fecha_Termino], [Periodo]) VALUES (2, CAST(N'2018-08-03 00:00:00.000' AS DateTime), CAST(N'2018-11-02 00:00:00.000' AS DateTime), N'2018-3')
GO
SET IDENTITY_INSERT [dbo].[CICLO] OFF
GO
SET IDENTITY_INSERT [dbo].[CREAR_TUTORIA] ON 

GO
INSERT [dbo].[CREAR_TUTORIA] ([Id_Tutoria], [Codigos_Asignatura], [Codigos_Maestro], [Codigos_Dias], [Codigos_Horas], [Codigos_Ciclo]) VALUES (1, 1, 1, 1, 1, 1)
GO
INSERT [dbo].[CREAR_TUTORIA] ([Id_Tutoria], [Codigos_Asignatura], [Codigos_Maestro], [Codigos_Dias], [Codigos_Horas], [Codigos_Ciclo]) VALUES (2, 5, 2, 1, 2, 1)
GO
INSERT [dbo].[CREAR_TUTORIA] ([Id_Tutoria], [Codigos_Asignatura], [Codigos_Maestro], [Codigos_Dias], [Codigos_Horas], [Codigos_Ciclo]) VALUES (3, 1, 1, 1, 3, 1)
GO
INSERT [dbo].[CREAR_TUTORIA] ([Id_Tutoria], [Codigos_Asignatura], [Codigos_Maestro], [Codigos_Dias], [Codigos_Horas], [Codigos_Ciclo]) VALUES (1004, 4, 4, 1, 4, 1)
GO
INSERT [dbo].[CREAR_TUTORIA] ([Id_Tutoria], [Codigos_Asignatura], [Codigos_Maestro], [Codigos_Dias], [Codigos_Horas], [Codigos_Ciclo]) VALUES (1005, 3, 4, 1, 5, 1)
GO
SET IDENTITY_INSERT [dbo].[CREAR_TUTORIA] OFF
GO
SET IDENTITY_INSERT [dbo].[DIAS] ON 

GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (1, N'Lunes')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (2, N'Martes')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (3, N'Miercoles')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (4, N'Jueves')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (5, N'Viernes')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (6, N'Sabado')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (7, N'Lunes-Miercoles')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (8, N'Miercoles-Viernes')
GO
INSERT [dbo].[DIAS] ([Id_Dias], [Nombre_Dias]) VALUES (9, N'Martes-Jueves')
GO
SET IDENTITY_INSERT [dbo].[DIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[ESTUDIANTE] ON 

GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (1, N'2016-0753', N'yerlin roniel', N'Beriguete', 1, N'849-227-1027', CAST(N'2018-07-28 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (2, N'2018-0008', N'Hugo', N'Mendez', 24, N'849-147-1477', CAST(N'2018-08-02 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (3, N'2018-0478', N'Antonio', N'Ferrari', 22, N'829-599-4657', CAST(N'2018-08-02 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (4, N'2015-0814', N'Piter', N'Parker', 3, N'849-447-1485', CAST(N'2018-08-04 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (5, N'2015-1984', N'Abel', N'Aramboles', 10, N'849-201-5961', CAST(N'2018-08-09 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (6, N'2018-0471', N'Martin ', N'Gonzales', 2, N'849-789-4785', CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (7, N'2018-0147', N'Gilberto', N'Santa Rosa', 7, N'829-789-4563', CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (8, N'2016-0874', N'Yeroni', N'Salas', 16, N'849-789-5687', CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (9, N'2018-1341', N'Filonemo', N'Saltamaria', 23, N'809-433-4040', CAST(N'2018-08-11 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ESTUDIANTE] ([Id_Estudiante], [Matricula_Estudiante], [Nombre_Estudiante], [Apellido_Estudiante], [Codigos_Carrera], [Telefono], [Fecha]) VALUES (10, N'2017-0847', N'Yanery', N'Hernandez', 21, N'829-579-4789', CAST(N'2018-08-12 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ESTUDIANTE] OFF
GO
SET IDENTITY_INSERT [dbo].[HORARIO] ON 

GO
INSERT [dbo].[HORARIO] ([Id_Horario], [Nombre_Horario]) VALUES (1, N'8:00 AM-10:00 AM')
GO
INSERT [dbo].[HORARIO] ([Id_Horario], [Nombre_Horario]) VALUES (2, N'10:00 AM-12:00 PM')
GO
INSERT [dbo].[HORARIO] ([Id_Horario], [Nombre_Horario]) VALUES (3, N'1:00 PM-3:00 PM')
GO
INSERT [dbo].[HORARIO] ([Id_Horario], [Nombre_Horario]) VALUES (4, N'3:00 PM-5:00 PM')
GO
INSERT [dbo].[HORARIO] ([Id_Horario], [Nombre_Horario]) VALUES (5, N'5:00 PM-7:00 PM')
GO
SET IDENTITY_INSERT [dbo].[HORARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[MAESTRO] ON 

GO
INSERT [dbo].[MAESTRO] ([Id_Maestro], [Codigos_Maestro], [Nombre_Maestro], [Departamento_Maestro], [Correo], [Telefono]) VALUES (1, N'D2018-001', N'Carlos Santos', N'Matematica', N'carlos@gmail.com', N'829-549-1647')
GO
INSERT [dbo].[MAESTRO] ([Id_Maestro], [Codigos_Maestro], [Nombre_Maestro], [Departamento_Maestro], [Correo], [Telefono]) VALUES (2, N'D2018-002', N'Gissell Matos', N'Matematica', N'Gissell@gmail.com', N'809-599-4657')
GO
INSERT [dbo].[MAESTRO] ([Id_Maestro], [Codigos_Maestro], [Nombre_Maestro], [Departamento_Maestro], [Correo], [Telefono]) VALUES (3, N'D2018-003', N'Sonia Mateo', N'Español', N'Sonia@gmail.com', N'829-621-4657')
GO
INSERT [dbo].[MAESTRO] ([Id_Maestro], [Codigos_Maestro], [Nombre_Maestro], [Departamento_Maestro], [Correo], [Telefono]) VALUES (4, N'D2018-004', N'Edwin Ozuna', N'Español', N'edwin011@gmail.com', N'849-449-1478')
GO
SET IDENTITY_INSERT [dbo].[MAESTRO] OFF
GO
SET IDENTITY_INSERT [dbo].[MAESTRO_MATERIA] ON 

GO
INSERT [dbo].[MAESTRO_MATERIA] ([Id_MaestroMateria], [Maestro], [Materia]) VALUES (1, 1, 1)
GO
INSERT [dbo].[MAESTRO_MATERIA] ([Id_MaestroMateria], [Maestro], [Materia]) VALUES (2, 2, 3)
GO
INSERT [dbo].[MAESTRO_MATERIA] ([Id_MaestroMateria], [Maestro], [Materia]) VALUES (3, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[MAESTRO_MATERIA] OFF
GO
SET IDENTITY_INSERT [dbo].[MATERIA] ON 

GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (1, N'Matematica')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (2, N'Matematica Discreta')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (3, N'Calculo Diferencial')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (4, N'Calculo Integral')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (5, N'Fisica')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (6, N'Quimica')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (7, N'Bioquimica')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (8, N'Español')
GO
INSERT [dbo].[MATERIA] ([Id_Materia], [Nombre_Materia]) VALUES (9, N'Taller de Ortagrafia')
GO
SET IDENTITY_INSERT [dbo].[MATERIA] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

GO
INSERT [dbo].[Usuarios] ([Id], [Dni], [Nombres], [Apellidos], [Cargo], [Email], [Contraseña]) VALUES (1, N'20160753', N'Yerlin ', N'Beriguee', N'Administrador', N'yerlin022@gmail.com', N'admin')
GO
INSERT [dbo].[Usuarios] ([Id], [Dni], [Nombres], [Apellidos], [Cargo], [Email], [Contraseña]) VALUES (2, N'12345', N'Mariel', N'Baez', N'Caja', N'gomezmichael684@gmail.com', N'1234')
GO
INSERT [dbo].[Usuarios] ([Id], [Dni], [Nombres], [Apellidos], [Cargo], [Email], [Contraseña]) VALUES (3, N'20160752', N'Roniel', N'Beriguee', N'administrador', N'yerlin022@gmail.com', N'admin')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_ASIGNAR_TUTORIA_CICLO] FOREIGN KEY([Ciclo])
REFERENCES [dbo].[CICLO] ([Id_Ciclo])
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA] CHECK CONSTRAINT [FK_ASIGNAR_TUTORIA_CICLO]
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_ASIGNAR_TUTORIA_ESTUDIANTE] FOREIGN KEY([Matricula])
REFERENCES [dbo].[ESTUDIANTE] ([Id_Estudiante])
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA] CHECK CONSTRAINT [FK_ASIGNAR_TUTORIA_ESTUDIANTE]
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_ASIGNAR_TUTORIA_MATERIA] FOREIGN KEY([Materia])
REFERENCES [dbo].[MATERIA] ([Id_Materia])
GO
ALTER TABLE [dbo].[ASIGNAR_TUTORIA] CHECK CONSTRAINT [FK_ASIGNAR_TUTORIA_MATERIA]
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD  CONSTRAINT [FK_ASISTENCIA_CREAR_TUTORIA] FOREIGN KEY([CodTutorias])
REFERENCES [dbo].[CREAR_TUTORIA] ([Id_Tutoria])
GO
ALTER TABLE [dbo].[ASISTENCIA] CHECK CONSTRAINT [FK_ASISTENCIA_CREAR_TUTORIA]
GO
ALTER TABLE [dbo].[ASISTENCIA]  WITH CHECK ADD  CONSTRAINT [FK_ASISTENCIA_ESTUDIANTE] FOREIGN KEY([CodEstudiante])
REFERENCES [dbo].[ESTUDIANTE] ([Id_Estudiante])
GO
ALTER TABLE [dbo].[ASISTENCIA] CHECK CONSTRAINT [FK_ASISTENCIA_ESTUDIANTE]
GO
ALTER TABLE [dbo].[CREAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_CREAR_TUTORIA_CICLO] FOREIGN KEY([Codigos_Ciclo])
REFERENCES [dbo].[CICLO] ([Id_Ciclo])
GO
ALTER TABLE [dbo].[CREAR_TUTORIA] CHECK CONSTRAINT [FK_CREAR_TUTORIA_CICLO]
GO
ALTER TABLE [dbo].[CREAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_CREAR_TUTORIA_DIAS] FOREIGN KEY([Codigos_Dias])
REFERENCES [dbo].[DIAS] ([Id_Dias])
GO
ALTER TABLE [dbo].[CREAR_TUTORIA] CHECK CONSTRAINT [FK_CREAR_TUTORIA_DIAS]
GO
ALTER TABLE [dbo].[CREAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_CREAR_TUTORIA_HORARIO] FOREIGN KEY([Codigos_Horas])
REFERENCES [dbo].[HORARIO] ([Id_Horario])
GO
ALTER TABLE [dbo].[CREAR_TUTORIA] CHECK CONSTRAINT [FK_CREAR_TUTORIA_HORARIO]
GO
ALTER TABLE [dbo].[CREAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_CREAR_TUTORIA_MAESTRO] FOREIGN KEY([Codigos_Maestro])
REFERENCES [dbo].[MAESTRO] ([Id_Maestro])
GO
ALTER TABLE [dbo].[CREAR_TUTORIA] CHECK CONSTRAINT [FK_CREAR_TUTORIA_MAESTRO]
GO
ALTER TABLE [dbo].[CREAR_TUTORIA]  WITH CHECK ADD  CONSTRAINT [FK_CREAR_TUTORIA_MATERIA] FOREIGN KEY([Codigos_Asignatura])
REFERENCES [dbo].[MATERIA] ([Id_Materia])
GO
ALTER TABLE [dbo].[CREAR_TUTORIA] CHECK CONSTRAINT [FK_CREAR_TUTORIA_MATERIA]
GO
ALTER TABLE [dbo].[ESTUDIANTE]  WITH CHECK ADD  CONSTRAINT [FK_ESTUDIANTE_CARRERA] FOREIGN KEY([Codigos_Carrera])
REFERENCES [dbo].[CARRERA] ([Id_Carrera])
GO
ALTER TABLE [dbo].[ESTUDIANTE] CHECK CONSTRAINT [FK_ESTUDIANTE_CARRERA]
GO
ALTER TABLE [dbo].[MAESTRO_MATERIA]  WITH CHECK ADD  CONSTRAINT [FK_MAESTRO_MATERIA_MAESTRO] FOREIGN KEY([Maestro])
REFERENCES [dbo].[MAESTRO] ([Id_Maestro])
GO
ALTER TABLE [dbo].[MAESTRO_MATERIA] CHECK CONSTRAINT [FK_MAESTRO_MATERIA_MAESTRO]
GO
ALTER TABLE [dbo].[MAESTRO_MATERIA]  WITH CHECK ADD  CONSTRAINT [FK_MAESTRO_MATERIA_MATERIA] FOREIGN KEY([Materia])
REFERENCES [dbo].[MATERIA] ([Id_Materia])
GO
ALTER TABLE [dbo].[MAESTRO_MATERIA] CHECK CONSTRAINT [FK_MAESTRO_MATERIA_MATERIA]
GO
/****** Object:  StoredProcedure [dbo].[CarrerasTomanTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CarrerasTomanTutorias]
as
select Top 10 C.Nombre_Carrera ,COUNT(E.Codigos_Carrera) as CantCarreras  from ESTUDIANTE AS E
inner join CARRERA AS C ON C.Id_Carrera=E.Codigos_Carrera
group by E.Codigos_Carrera,C.Nombre_Carrera 
order by count (2) DESC







GO
/****** Object:  StoredProcedure [dbo].[DashboardDatos]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DashboardDatos]
@IdEstudiante int out,
@IdCarrera int out ,
@IdMaestro int out ,
@IdMateria int out ,
@IdTutoria int out 
as
set @IdEstudiante =(select count(Id_Estudiante) AS CantidadEstudiante from ESTUDIANTE)
set @IdCarrera =(select count(Id_Carrera) AS CantidadCarrera from CARRERA)
set @IdMaestro =(select count(Id_Maestro) AS CantidadMaestro from MAESTRO)
set @IdMateria =(select count(Id_Materia) AS CantidadMateria from MATERIA)
set @IdTutoria =(select count(Id_Tutoria) AS CantidadTutoria from CREAR_TUTORIA)







GO
/****** Object:  StoredProcedure [dbo].[EditarAsignaciones]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarAsignaciones]
@Matricula  int,
@Asignatura  int,

@Periodo    int,
@IdAsignarTutorias  int

as
update ASIGNAR_TUTORIA set Matricula=@Matricula ,Materia =@Asignatura,
Ciclo=@Periodo 
where Id_AsignarTutoria=@IdAsignarTutorias










GO
/****** Object:  StoredProcedure [dbo].[EditarAsistencia]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarAsistencia]
@CodMatricula  int,
@CodTutoria  int,
@Fecha  datetime ,
@IdAsistencia int
as 
UPDATE ASISTENCIA SET CodEstudiante =@CodMatricula,CodTutorias=@CodTutoria ,Fecha=@Fecha
 where Id_Asistencia =@IdAsistencia


GO
/****** Object:  StoredProcedure [dbo].[EditarCiclos]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarCiclos]

@FechaInicio datetime,
@FechaTermino datetime,
@Periodo  nvarchar (100),
@IdCiclo int

as
update  CICLO set Fecha_Inicio =@FechaInicio,Fecha_Termino= @FechaTermino,
Periodo =@Periodo where Id_Ciclo =@IdCiclo





GO
/****** Object:  StoredProcedure [dbo].[EditarEstudiantes]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarEstudiantes]
@Matricula nvarchar (100),
@Nombre    nvarchar (100),
@Apellido  nvarchar (100),
@IdCarrera int,
@Telefono  nvarchar (100),
@idEstudiante int
as
update ESTUDIANTE set Matricula_Estudiante=@Matricula, Nombre_Estudiante=@Nombre, Apellido_Estudiante=@Apellido,Codigos_Carrera=@IdCarrera,Telefono=@Telefono where Id_Estudiante=@idEstudiante





GO
/****** Object:  StoredProcedure [dbo].[EditarMaestros]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarMaestros]

@CodMaestro nvarchar(100),
@Nombre nvarchar(100) ,
@Departamento nvarchar(100) ,
@Correo nvarchar(100) ,
@Telefono nvarchar(100) ,
@IdMaestro nvarchar(100) 
as
update MAESTRO set Codigos_Maestro=@CodMaestro,Nombre_Maestro=@Nombre,
Departamento_Maestro=@Departamento,Correo=@Correo ,Telefono=@Telefono  WHERE Id_Maestro = @IdMaestro 









GO
/****** Object:  StoredProcedure [dbo].[EditarTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarTutorias]
@IdMateria  int,
@IdMaestro  int,
@IdDia      int,
@IdHorario  int,
@IdCiclo    int,
@IdTutoria  int

as
update CREAR_TUTORIA set Codigos_Asignatura=@IdMateria,Codigos_Maestro =@IdMaestro,
Codigos_Dias=@IdDia,Codigos_Horas =@IdHorario,Codigos_Ciclo =@IdCiclo
where Id_Tutoria=@IdTutoria









GO
/****** Object:  StoredProcedure [dbo].[EditarUsuarios]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarUsuarios]
@Dni nvarchar (100),
@Nombre nvarchar (100),
@Apellido nvarchar (100),
@Cargo nvarchar (100),
@Email nvarchar (100),
@Contraseña nvarchar (100),
@Id int
as
update Usuarios set  Dni=@Dni, Nombres=@Nombre,Apellidos=@Apellido,Cargo=@Cargo,Email=@Email,
Contraseña=@Contraseña where Id = @Id





GO
/****** Object:  StoredProcedure [dbo].[EliminarAsignaciones]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarAsignaciones]

@IdAsignarTutorias  int

as
delete from  ASIGNAR_TUTORIA 


where Id_AsignarTutoria=@IdAsignarTutorias



GO
/****** Object:  StoredProcedure [dbo].[EliminarAsistencia]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarAsistencia]

@IdAsistencia  int
as
delete from ASISTENCIA
where Id_Asistencia=@IdAsistencia









GO
/****** Object:  StoredProcedure [dbo].[EliminarCiclos]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarCiclos]


@IdCiclo int

as
delete from  CICLO where Id_Ciclo =@IdCiclo





GO
/****** Object:  StoredProcedure [dbo].[EliminarEstudiantes]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarEstudiantes]
@idEstudiante int
as
delete from ESTUDIANTE where Id_Estudiante=@idEstudiante






GO
/****** Object:  StoredProcedure [dbo].[EliminarTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarTutorias]
@IdTutoria int
as
delete from CREAR_TUTORIA where Id_Tutoria=@IdTutoria





GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuarios]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarUsuarios]
@Id int
as
delete from Usuarios where Id =@Id





GO
/****** Object:  StoredProcedure [dbo].[InsertarAsignaciones]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarAsignaciones]
@Matricula  int,
@Asignatura  int,

@Periodo    int
as
insert into ASIGNAR_TUTORIA values
(@Matricula,@Asignatura ,
@Periodo) 




GO
/****** Object:  StoredProcedure [dbo].[InsertarAsistencia]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarAsistencia]
@CodMatricula  int,
@CodTutoria  int,
@Fecha  datetime 
as 
insert into ASISTENCIA values (@CodMatricula,@CodTutoria ,@Fecha)




GO
/****** Object:  StoredProcedure [dbo].[InsertarCiclos]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertarCiclos]

@FechaInicio datetime,
@FechaTermino datetime,
@Periodo  nvarchar (100)

as
insert into CICLO values (@FechaInicio,@FechaTermino,@Periodo)









GO
/****** Object:  StoredProcedure [dbo].[InsertarEstudiantes]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarEstudiantes]
@Matricula nvarchar (100),
@Nombre nvarchar (100),
@Apellido nvarchar (100),
@CodCarrera int,
@Telefono  nvarchar (100),
@Fecha datetime

as
if(not exists(select Matricula_Estudiante FROM ESTUDIANTE where Matricula_Estudiante =@Matricula )) --esta condicion verifica si no existe el dato, y de cumplirse la condicion insertará  y si existe el dato simplemente no hará nada, no insertara 
insert into ESTUDIANTE values (@Matricula,@Nombre,@Apellido,@CodCarrera,@Telefono,@Fecha)









GO
/****** Object:  StoredProcedure [dbo].[InsertarMaestros]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarMaestros]
@CodMaestro nvarchar(100),
@Nombre nvarchar(100) ,
@Departamento nvarchar(100) ,
@Correo nvarchar(100) ,
@Telefono nvarchar(100) 
 


as
insert into MAESTRO values (@CodMaestro,@Nombre,@Departamento,@Correo,@Telefono)













GO
/****** Object:  StoredProcedure [dbo].[InsertarTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarTutorias]
@IdMateria  int,
@IdDia      int,
@IdHorario  int,
@IdMaestro  int,
@IdCiclo    nvarchar (100)
 as
 if(not exists(select Codigos_Dias,Codigos_Horas,Codigos_Maestro from CREAR_TUTORIA 
 where  Codigos_Dias=@IdDia AND Codigos_Horas=@IdHorario AND Codigos_Maestro =@IdMaestro )) 
insert into CREAR_TUTORIA values (@IdMateria,@IdDia,@IdHorario,@IdMaestro,@IdCiclo)

GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuarios]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarUsuarios]
@Dni nvarchar (100),
@Nombre nvarchar (100),
@Apellido nvarchar (100),
@Cargo nvarchar (100),
@Email nvarchar (100),
@Contraseña nvarchar (100)

as
if(not exists(select Dni FROM Usuarios where  Dni=@Dni )) --esta condicion verifica si no existe el dato, y de cumplirse la condicion insertará  y si existe el dato simplemente no hará nada, no insertara 

insert into Usuarios values (@Dni,@Nombre,@Apellido,@Cargo,@Email,@Contraseña)






GO
/****** Object:  StoredProcedure [dbo].[MateriasTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MateriasTutorias]
as
select  M.Nombre_Materia ,COUNT(AT.Materia) as CantMaterias  from ASIGNAR_TUTORIA AS AT

inner join MATERIA AS M ON M.Id_Materia=AT.Materia
group by AT.Materia,M.Nombre_Materia 
order by count (2) DESC



GO
/****** Object:  StoredProcedure [dbo].[MostrarApellido]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarApellido]
as
select Id_Estudiante ,Apellido_Estudiante from ESTUDIANTE



GO
/****** Object:  StoredProcedure [dbo].[MostrarAsignaciones]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarAsignaciones]
as
select Id_AsignarTutoria ,E.Matricula_Estudiante,M.Nombre_Materia,C.Periodo from ASIGNAR_TUTORIA as A
INNER JOIN ESTUDIANTE AS E ON E.Id_Estudiante = A.Matricula 
INNER JOIN MATERIA AS M  ON M.Id_Materia =A.Materia
INNER JOIN CICLO AS C  ON C.Id_Ciclo = A.Ciclo










GO
/****** Object:  StoredProcedure [dbo].[MostrarAsistencia]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarAsistencia]
as
select  A.Id_Asistencia,E.Matricula_Estudiante,E.Nombre_Estudiante,E.Apellido_Estudiante,M.Nombre_Materia,
MA.Nombre_Maestro ,D.Nombre_Dias,H.Nombre_Horario from ASISTENCIA AS A INNER JOIN ESTUDIANTE AS E ON 
A.Id_Asistencia=E.Id_Estudiante
INNER JOIN CREAR_TUTORIA AS C ON
A.Id_Asistencia=C.Id_Tutoria
INNER JOIN MATERIA AS M ON
C.Id_Tutoria = Id_Materia
INNER JOIN MAESTRO AS MA ON 
C.Id_Tutoria = Id_Maestro
INNER JOIN DIAS AS D ON 
C.Id_Tutoria = Id_Dias
INNER JOIN HORARIO AS H ON 
C.Id_Tutoria = Id_Horario

order by Id_Asistencia asc


GO
/****** Object:  StoredProcedure [dbo].[MostrarAsistencia2]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[MostrarAsistencia2]
as
select  A.Id_Asistencia,E.Matricula_Estudiante,E.Nombre_Estudiante,E.Apellido_Estudiante,C.Codigos_Asignatura,
C.Codigos_Maestro ,C.Codigos_Dias,C.Codigos_Horas from ASISTENCIA AS A INNER JOIN ESTUDIANTE AS E ON 
A.Id_Asistencia=E.Id_Estudiante
INNER JOIN CREAR_TUTORIA AS C ON
A.Id_Asistencia=C.Id_Tutoria


GO
/****** Object:  StoredProcedure [dbo].[MostrarAsistencia3]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarAsistencia3]
as

select  A.Id_Asistencia,E.Matricula_Estudiante,E.Nombre_Estudiante,E.Apellido_Estudiante, M.Nombre_Materia,MA.Nombre_Maestro,D.Nombre_Dias,H.Nombre_Horario
 from ASISTENCIA AS A INNER JOIN ESTUDIANTE AS E ON 
A.Id_Asistencia=E.Id_Estudiante
INNER JOIN CREAR_TUTORIA AS C ON
A.Id_Asistencia=C.Id_Tutoria

INNER JOIN MATERIA AS M ON
M.Id_Materia = C.Codigos_Asignatura

INNER JOIN MAESTRO AS MA ON
MA.Id_Maestro = C.Codigos_Maestro

INNER JOIN DIAS AS D ON
D.Id_Dias = C.Codigos_Dias

INNER JOIN HORARIO AS H ON
H.Id_Horario = C.Codigos_Horas

WHERE A.Asignatura = Codigos_Asignatura AND A.Asignatura = M.Id_Materia  OR A.Maestro = C.Codigos_Maestro 
AND A.Maestro = MA.Id_Maestro OR A.Dia = C.Codigos_Dias AND A.Dia = D.Id_Dias OR A.Horario = C.Codigos_Horas 
AND A.Horario = H.Id_Horario





GO
/****** Object:  StoredProcedure [dbo].[MostrarAsistencia4]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarAsistencia4]
as
select DISTINCT Id_Asistencia ,A.CodEstudiante,A.CodTutorias,E.Matricula_Estudiante as Matricula , M.Nombre_Materia as Materia ,
D.Nombre_Dias as Dias,H.Nombre_Horario as Horario ,MA.Nombre_Maestro as Maestro,PER.Periodo ,A.fecha from ASISTENCIA AS A 

INNER JOIN ESTUDIANTE AS E 
ON Id_Estudiante = A.CodEstudiante 

INNER JOIN CREAR_TUTORIA AS C 
ON Id_Tutoria  = A.CodTutorias

INNER JOIN MATERIA as M
ON M.Id_Materia = C.Codigos_Asignatura

INNER JOIN DIAS AS D ON 
D.Id_Dias = C.Codigos_Dias 

INNER JOIN HORARIO AS H ON 
H.Id_Horario = C.Codigos_Horas

INNER JOIN MAESTRO as MA
ON MA.Id_Maestro = C.Codigos_Maestro

INNER JOIN CICLO AS PER
ON PER.Id_Ciclo = C.Codigos_Ciclo

INNER JOIN ASIGNAR_TUTORIA AS AT
on AT.Matricula = E.Id_Estudiante 






GO
/****** Object:  StoredProcedure [dbo].[MostrarAsistenciaX]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarAsistenciaX]
as
SELECT Id_Asistencia,Matricula_Estudiante,Nombre_Estudiante,Apellido_Estudiante,Nombre_Materia,Nombre_Maestro,Nombre_Dias,
H.Nombre_Horario
from ASISTENCIA as A
INNER JOIN ESTUDIANTE AS E on
A.Id_Matricula = E.Id_Estudiante 
INNER JOIN MATERIA AS M on
A.Asignatura = M.Id_Materia
INNER JOIN MAESTRO AS MA on
A.Maestro = MA.Id_Maestro
INNER JOIN DIAS AS D on
A.Dia = D.Id_Dias
INNER JOIN HORARIO AS H on
A.Horario = H.Id_Horario

GO
/****** Object:  StoredProcedure [dbo].[MostrarCarreras]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarCarreras]
as
select Id_Carrera,Nombre_Carrera from CARRERA





GO
/****** Object:  StoredProcedure [dbo].[MostrarCiclo]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[MostrarCiclo]
AS
select Id_Ciclo,Periodo from CICLO






GO
/****** Object:  StoredProcedure [dbo].[MostrarCicloGestionar]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarCicloGestionar]
AS
select * from CICLO







GO
/****** Object:  StoredProcedure [dbo].[MostrarCodTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarCodTutorias]
AS
SELECT DISTINCT Id_Tutoria from CREAR_TUTORIA



GO
/****** Object:  StoredProcedure [dbo].[MostrarDias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarDias]
as
select Id_Dias,Nombre_Dias from DIAS









GO
/****** Object:  StoredProcedure [dbo].[MostrarEstudiantes]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarEstudiantes]
as
select E.Id_Estudiante  ,E.Matricula_Estudiante,E.Nombre_Estudiante,E.Apellido_Estudiante,C.Nombre_Carrera,E.Telefono,
E.Fecha from ESTUDIANTE as E
inner join CARRERA as C on E.Codigos_Carrera = C.Id_Carrera













GO
/****** Object:  StoredProcedure [dbo].[MostrarHorarios]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarHorarios]
as
select Id_Horario,Nombre_Horario from HORARIO









GO
/****** Object:  StoredProcedure [dbo].[MostrarMaestros]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[MostrarMaestros]
as
select Id_Maestro, Codigos_Maestro as Codigo ,Nombre_Maestro as Nombre
,Departamento_Maestro as Departamento ,Correo ,Telefono from  MAESTRO












GO
/****** Object:  StoredProcedure [dbo].[MostrarMaterias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarMaterias]
as
select Id_Materia,Nombre_Materia from MATERIA






GO
/****** Object:  StoredProcedure [dbo].[MostrarMatricula]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarMatricula]
as
select Id_Estudiante,Matricula_Estudiante from ESTUDIANTE 
ORDER BY Matricula_Estudiante











GO
/****** Object:  StoredProcedure [dbo].[MostrarMatriculaAsistencias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarMatriculaAsistencias]
as

select DISTINCT Id_Estudiante,Matricula_Estudiante from ESTUDIANTE AS E
INNER JOIN ASIGNAR_TUTORIA AS AT
on AT.Matricula = E.Id_Estudiante 
ORDER BY Id_Estudiante 


GO
/****** Object:  StoredProcedure [dbo].[MostrarNombre]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarNombre]
as
select Id_Estudiante ,Nombre_Estudiante from ESTUDIANTE



GO
/****** Object:  StoredProcedure [dbo].[MostrarNombreMaestro]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarNombreMaestro]
as
select Id_Maestro,Nombre_Maestro from MAESTRO










GO
/****** Object:  StoredProcedure [dbo].[MostrarReportesAsistencias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MostrarReportesAsistencias]
@Fecha datetime 
as
select DISTINCT Id_Asistencia ,A.CodEstudiante,A.CodTutorias,E.Matricula_Estudiante as Matricula , M.Nombre_Materia as Materia ,
D.Nombre_Dias as Dias,H.Nombre_Horario as Horario ,MA.Nombre_Maestro as Maestro,PER.Periodo ,A.fecha from ASISTENCIA AS A 

INNER JOIN ESTUDIANTE AS E 
ON Id_Estudiante = A.CodEstudiante 

INNER JOIN CREAR_TUTORIA AS C 
ON Id_Tutoria  = A.CodTutorias

INNER JOIN MATERIA as M
ON M.Id_Materia = C.Codigos_Asignatura

INNER JOIN DIAS AS D ON 
D.Id_Dias = C.Codigos_Dias 

INNER JOIN HORARIO AS H ON 
H.Id_Horario = C.Codigos_Horas

INNER JOIN MAESTRO as MA
ON MA.Id_Maestro = C.Codigos_Maestro

INNER JOIN CICLO AS PER
ON PER.Id_Ciclo = C.Codigos_Ciclo

INNER JOIN ASIGNAR_TUTORIA AS AT
on AT.Matricula = E.Id_Estudiante 




where A.fecha = @Fecha






GO
/****** Object:  StoredProcedure [dbo].[MostrarReportesTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarReportesTutorias]
@Ciclo int
as
select T.Id_Tutoria,M.Nombre_Materia as Materia,D.Nombre_Dias as Dias, H.Nombre_Horario as Horario,
MA.Nombre_Maestro as Nombre,C.Periodo from CREAR_TUTORIA AS T 
inner join MATERIA as M on T.Codigos_Asignatura=M.Id_Materia
inner join DIAS as D on T.Codigos_Dias         = D.Id_Dias 
inner join HORARIO as H on T.Codigos_Horas     = H.Id_Horario
inner join MAESTRO as MA on T.Codigos_Maestro  = MA.Id_Maestro
inner join CICLO   as C  on T.Codigos_Ciclo    = C.Id_Ciclo
where C.Id_Ciclo = @Ciclo 

GO
/****** Object:  StoredProcedure [dbo].[MostrarTutorias]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTutorias]
as
select T.Id_Tutoria,M.Nombre_Materia as Materia,D.Nombre_Dias as Dias, H.Nombre_Horario as Horario,
MA.Nombre_Maestro as Nombre,C.Periodo from CREAR_TUTORIA AS T 
inner join MATERIA as M on T.Codigos_Asignatura=M.Id_Materia
inner join DIAS as D on T.Codigos_Dias         = D.Id_Dias 
inner join HORARIO as H on T.Codigos_Horas     = H.Id_Horario
inner join MAESTRO as MA on T.Codigos_Maestro  = MA.Id_Maestro
inner join CICLO   as C  on T.Codigos_Ciclo    = C.Id_Ciclo










GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarUsuarios]
as
select *from Usuarios











GO
/****** Object:  StoredProcedure [dbo].[SpLogin]    Script Date: 8/18/2018 2:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpLogin] 
    @Usuario nvarchar(50), 
    @Password nvarchar(50) 
AS 
    SELECT * FROM Usuarios
    WHERE Dni = @Usuario AND Contraseña = @Password;










GO
USE [master]
GO
ALTER DATABASE [BD_Registro_Tutorias] SET  READ_WRITE 
GO

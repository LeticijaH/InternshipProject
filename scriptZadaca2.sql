USE [master]
GO
/****** Object:  Database [Test]    Script Date: 17.08.2022 08:59:06 ******/

GO
ALTER DATABASE [ProductionDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductionDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductionDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductionDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductionDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductionDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductionDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductionDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductionDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductionDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductionDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductionDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductionDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductionDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductionDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductionDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductionDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductionDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductionDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProductionDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProductionDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductionDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductionDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductionDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProductionDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProductionDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProductionDB] SET QUERY_STORE = OFF
GO
USE [ProductionDB]
GO
/****** Object:  Schema [Config Schema]    Script Date: 17.08.2022 08:59:06 ******/
CREATE SCHEMA [Config Schema]
GO
/****** Object:  Schema [Data Schema]    Script Date: 17.08.2022 08:59:06 ******/
CREATE SCHEMA [Data Schema]
GO
/****** Object:  Table [Config Schema].[DefinedMachines]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[DefinedMachines](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MachineTypeID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_DefinedMachines] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[MachineType]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[MachineType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](3) NOT NULL,
 CONSTRAINT [PK_MachineType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[Operators]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[Operators](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](15) NOT NULL,
	[LastName] [varchar](25) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Pass] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Operators] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[ProductionPart]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[ProductionPart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](11) NOT NULL,
	[Description] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ProductionPart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[ProductionPartCompatible Machine]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[ProductionPartCompatible Machine](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PartID] [int] NOT NULL,
	[MachineTypeID] [int] NOT NULL,
 CONSTRAINT [PK_ProductionPartCompatible Machine] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[UsedMaterialManufacturer]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[UsedMaterialManufacturer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UsedMaterialManufacturer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Config Schema].[UsedMaterialType]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Config Schema].[UsedMaterialType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UsedMaterialType] [varchar](15) NOT NULL,
 CONSTRAINT [PK_UsedMaterialType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data Schema].[OperatorsLogin]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data Schema].[OperatorsLogin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OperatorID] [int] NOT NULL,
	[Timestamp] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_OperatorsLogin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data Schema].[ProductionPiece]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data Schema].[ProductionPiece](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [int] NOT NULL,
	[PartID] [int] NOT NULL,
	[OperatorID] [int] NOT NULL,
	[Timestamp] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_ProductionPiece] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data Schema].[ProductionPiecePropertiesDefinition]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data Schema].[ProductionPiecePropertiesDefinition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[PartID] [int] NOT NULL,
 CONSTRAINT [PK_ProductionPiecePropertiesDefinition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data Schema].[ProductionPiecePropertiesValue]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data Schema].[ProductionPiecePropertiesValue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PropertyID] [int] NOT NULL,
	[Value] [int] NULL,
	[PieceID] [int] NOT NULL,
 CONSTRAINT [PK_ProductionPiecePropertiesValue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Data Schema].[UsedMaterials]    Script Date: 17.08.2022 08:59:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data Schema].[UsedMaterials](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UsedMaterialTypeID] [int] NOT NULL,
	[ManufacturerID] [int] NOT NULL,
	[PieceID] [int] NOT NULL,
 CONSTRAINT [PK_UsedMaterials] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Config Schema].[DefinedMachines]  WITH CHECK ADD  CONSTRAINT [DefinedMachines_MachineType] FOREIGN KEY([MachineTypeID])
REFERENCES [Config Schema].[MachineType] ([ID])
GO
ALTER TABLE [Config Schema].[DefinedMachines] CHECK CONSTRAINT [DefinedMachines_MachineType]
GO
ALTER TABLE [Config Schema].[ProductionPartCompatible Machine]  WITH CHECK ADD  CONSTRAINT [ProductionPartCompatible Machine_MachineType] FOREIGN KEY([MachineTypeID])
REFERENCES [Config Schema].[MachineType] ([ID])
GO
ALTER TABLE [Config Schema].[ProductionPartCompatible Machine] CHECK CONSTRAINT [ProductionPartCompatible Machine_MachineType]
GO
ALTER TABLE [Config Schema].[ProductionPartCompatible Machine]  WITH CHECK ADD  CONSTRAINT [ProductionPartCompatible Machine_ProductionPart] FOREIGN KEY([PartID])
REFERENCES [Config Schema].[ProductionPart] ([ID])
GO
ALTER TABLE [Config Schema].[ProductionPartCompatible Machine] CHECK CONSTRAINT [ProductionPartCompatible Machine_ProductionPart]
GO
ALTER TABLE [Data Schema].[OperatorsLogin]  WITH CHECK ADD  CONSTRAINT [OperatorsLogin_Operators] FOREIGN KEY([OperatorID])
REFERENCES [Config Schema].[Operators] ([ID])
GO
ALTER TABLE [Data Schema].[OperatorsLogin] CHECK CONSTRAINT [OperatorsLogin_Operators]
GO
ALTER TABLE [Data Schema].[ProductionPiece]  WITH CHECK ADD  CONSTRAINT [ProductionPiece_Operators] FOREIGN KEY([OperatorID])
REFERENCES [Config Schema].[Operators] ([ID])
GO
ALTER TABLE [Data Schema].[ProductionPiece] CHECK CONSTRAINT [ProductionPiece_Operators]
GO
ALTER TABLE [Data Schema].[ProductionPiece]  WITH CHECK ADD  CONSTRAINT [ProductionPiece_ProductionPart] FOREIGN KEY([PartID])
REFERENCES [Config Schema].[ProductionPart] ([ID])
GO
ALTER TABLE [Data Schema].[ProductionPiece] CHECK CONSTRAINT [ProductionPiece_ProductionPart]
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesDefinition]  WITH CHECK ADD  CONSTRAINT [ProductionPiecePropertiesDefinition_ProductionPart] FOREIGN KEY([PartID])
REFERENCES [Config Schema].[ProductionPart] ([ID])
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesDefinition] CHECK CONSTRAINT [ProductionPiecePropertiesDefinition_ProductionPart]
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesValue]  WITH CHECK ADD  CONSTRAINT [ProductionPiecePropertiesValue_ProductionPiece] FOREIGN KEY([PieceID])
REFERENCES [Data Schema].[ProductionPiece] ([ID])
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesValue] CHECK CONSTRAINT [ProductionPiecePropertiesValue_ProductionPiece]
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesValue]  WITH CHECK ADD  CONSTRAINT [ProductionPiecePropertiesValue_ProductionPiecePropertiesDefinition] FOREIGN KEY([PropertyID])
REFERENCES [Data Schema].[ProductionPiecePropertiesDefinition] ([ID])
GO
ALTER TABLE [Data Schema].[ProductionPiecePropertiesValue] CHECK CONSTRAINT [ProductionPiecePropertiesValue_ProductionPiecePropertiesDefinition]
GO
ALTER TABLE [Data Schema].[UsedMaterials]  WITH CHECK ADD  CONSTRAINT [UsedMaterials_ProductionPiece] FOREIGN KEY([PieceID])
REFERENCES [Data Schema].[ProductionPiece] ([ID])
GO
ALTER TABLE [Data Schema].[UsedMaterials] CHECK CONSTRAINT [UsedMaterials_ProductionPiece]
GO
ALTER TABLE [Data Schema].[UsedMaterials]  WITH CHECK ADD  CONSTRAINT [UsedMaterials_UsedMaterialManufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [Config Schema].[UsedMaterialManufacturer] ([ID])
GO
ALTER TABLE [Data Schema].[UsedMaterials] CHECK CONSTRAINT [UsedMaterials_UsedMaterialManufacturer]
GO
ALTER TABLE [Data Schema].[UsedMaterials]  WITH CHECK ADD  CONSTRAINT [UsedMaterials_UsedMaterialType] FOREIGN KEY([UsedMaterialTypeID])
REFERENCES [Config Schema].[UsedMaterialType] ([ID])
GO
ALTER TABLE [Data Schema].[UsedMaterials] CHECK CONSTRAINT [UsedMaterials_UsedMaterialType]
GO
USE [master]
GO
ALTER DATABASE [ProductionDB] SET  READ_WRITE 
GO

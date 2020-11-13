USE [master]
GO
/****** Object:  Database [MyBookStore]    Script Date: 11/12/2020 9:32:57 AM ******/
CREATE DATABASE [MyBookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyBookStore', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyBookStore.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyBookStore_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyBookStore_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyBookStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyBookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyBookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyBookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyBookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyBookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyBookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyBookStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MyBookStore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MyBookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyBookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyBookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyBookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyBookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyBookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyBookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyBookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyBookStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MyBookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyBookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyBookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyBookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyBookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyBookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyBookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyBookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyBookStore] SET  MULTI_USER 
GO
ALTER DATABASE [MyBookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyBookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyBookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyBookStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MyBookStore]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/12/2020 9:32:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](100) NOT NULL,
	[Fullname] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Role] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](1000) NULL,
	[Phone] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Book]    Script Date: 11/12/2020 9:32:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Price] [int] NULL,
	[Quantity] [int] NOT NULL,
	[Author] [nvarchar](100) NULL,
	[Publisher] [nvarchar](100) NULL,
	[CategoryID] [int] NOT NULL,
	[IsLocal] [bit] NULL,
	[Image] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cart]    Script Date: 11/12/2020 9:32:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[CartID] [int] IDENTITY(1,1) NOT NULL,
	[DateOrder] [date] NOT NULL,
	[DateReceive] [date] NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Status] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CartDetail]    Script Date: 11/12/2020 9:32:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetail](
	[CartDetailID] [int] IDENTITY(1,1) NOT NULL,
	[CartID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CartDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/12/2020 9:32:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_Category] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Anonymous') FOR [Fullname]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'123456') FOR [Password]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'User') FOR [Role]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Hồ Chí Minh') FOR [Address]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'0123456789') FOR [Phone]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT ('2020-1-1') FOR [DateOrder]
GO
ALTER TABLE [dbo].[Cart] ADD  DEFAULT (N'Not done') FOR [Status]
GO
ALTER TABLE [dbo].[CartDetail] ADD  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[Account] ([Username])
GO
ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([BookID])
GO
ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD FOREIGN KEY([CartID])
REFERENCES [dbo].[Cart] ([CartID])
GO
USE [master]
GO
ALTER DATABASE [MyBookStore] SET  READ_WRITE 
GO

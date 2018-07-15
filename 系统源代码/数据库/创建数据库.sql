USE [master]
GO

/****** Object:  Database [会员管理系统1.0]    Script Date: 2018/7/14 20:54:55 ******/
CREATE DATABASE [会员管理系统1.0]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'会员管理系统1.0', FILENAME = N'E:\SQL\根目录\MSSQL12.SQLEXPRESS\MSSQL\DATA\会员管理系统1.0.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'会员管理系统1.0_log', FILENAME = N'E:\SQL\根目录\MSSQL12.SQLEXPRESS\MSSQL\DATA\会员管理系统1.0_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [会员管理系统1.0] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [会员管理系统1.0].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [会员管理系统1.0] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET ARITHABORT OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [会员管理系统1.0] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [会员管理系统1.0] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET  DISABLE_BROKER 
GO

ALTER DATABASE [会员管理系统1.0] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [会员管理系统1.0] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [会员管理系统1.0] SET  MULTI_USER 
GO

ALTER DATABASE [会员管理系统1.0] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [会员管理系统1.0] SET DB_CHAINING OFF 
GO

ALTER DATABASE [会员管理系统1.0] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [会员管理系统1.0] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [会员管理系统1.0] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [会员管理系统1.0] SET  READ_WRITE 
GO



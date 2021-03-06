USE [master]
GO
/****** Object:  Database [boleto_db]    Script Date: 1/6/2021 11:50:32 AM ******/
CREATE DATABASE [boleto_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'boleto_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SUCANABO\MSSQL\DATA\boleto_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'boleto_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SUCANABO\MSSQL\DATA\boleto_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [boleto_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [boleto_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [boleto_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [boleto_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [boleto_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [boleto_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [boleto_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [boleto_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [boleto_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [boleto_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [boleto_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [boleto_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [boleto_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [boleto_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [boleto_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [boleto_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [boleto_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [boleto_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [boleto_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [boleto_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [boleto_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [boleto_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [boleto_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [boleto_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [boleto_db] SET RECOVERY FULL 
GO
ALTER DATABASE [boleto_db] SET  MULTI_USER 
GO
ALTER DATABASE [boleto_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [boleto_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [boleto_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [boleto_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [boleto_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [boleto_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'boleto_db', N'ON'
GO
ALTER DATABASE [boleto_db] SET QUERY_STORE = OFF
GO
USE [boleto_db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[actors]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[image] [nvarchar](max) NULL,
 CONSTRAINT [PK_actors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branches]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_branches] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contactForms]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contactForms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[status] [int] NOT NULL,
	[create_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_contactForms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discounts]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[discount_percent] [float] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_discounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movie_Actors]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_Actors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NOT NULL,
	[actor_id] [int] NOT NULL,
 CONSTRAINT [PK_movie_Actors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movie_Categories]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NOT NULL,
	[movie_id] [int] NOT NULL,
 CONSTRAINT [PK_movie_Categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie_Discount]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie_Discount](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NOT NULL,
	[discount_id] [int] NOT NULL,
 CONSTRAINT [PK_Movie_Discount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movies]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[summery] [nvarchar](max) NOT NULL,
	[trailer_path] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
	[duration] [int] NOT NULL,
	[published_date] [datetime2](7) NOT NULL,
	[poster] [nvarchar](max) NULL,
 CONSTRAINT [PK_movies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[total_price] [float] NOT NULL,
	[status] [int] NOT NULL,
	[create_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reports]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reports](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reason] [nvarchar](max) NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[review_id] [int] NOT NULL,
	[create_date] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_reports] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reviews]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reviews](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[movie_id] [int] NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[heart_rate] [int] NOT NULL,
	[create_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_reviews] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[branch_id] [int] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedules]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NOT NULL,
	[movie_id] [int] NOT NULL,
	[start_time] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_schedules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seat_status]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seat_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[seat_id] [int] NOT NULL,
	[ticket_id] [int] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_seat_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seats]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NOT NULL,
	[position] [nvarchar](max) NULL,
 CONSTRAINT [PK_seats] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[schedule_id] [int] NULL,
	[price] [float] NOT NULL,
	[Roomid] [int] NULL,
 CONSTRAINT [PK_tickets] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userDiscounts]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userDiscounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[discount_id] [int] NOT NULL,
 CONSTRAINT [PK_userDiscounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 1/6/2021 11:50:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[displayname] [nvarchar](255) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[birthday] [datetime2](7) NOT NULL,
	[avatar] [nvarchar](max) NULL,
	[rule] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210104035658_initialCreate', N'5.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210104041617_Movie_addColumn_poster', N'5.0.1')
GO
SET IDENTITY_INSERT [dbo].[actors] ON 

INSERT [dbo].[actors] ([id], [name], [image]) VALUES (1, N'Angelina Jolie', N'1.jpg')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (2, N'Margot Robbie', N'2.jpg')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (3, N'Emma Watson', N'3.jpg')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (4, N'Gal Gadot', N'4.jpg')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (5, N'Samuell Jackson', N'5.webp')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (6, N'Tom Cruise', N'6.webp')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (7, N'Jackie Chan', N'7.webp')
INSERT [dbo].[actors] ([id], [name], [image]) VALUES (8, N'Vin Diesel', N'8.webp')
SET IDENTITY_INSERT [dbo].[actors] OFF
GO
SET IDENTITY_INSERT [dbo].[branches] ON 

INSERT [dbo].[branches] ([id], [name], [address], [status]) VALUES (1, N'Nguyen Du', N'12A, Nguyen Du, 1 district', 1)
INSERT [dbo].[branches] ([id], [name], [address], [status]) VALUES (3, N'3/2', N'3/2, 10 distric', 1)
SET IDENTITY_INSERT [dbo].[branches] OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([id], [name], [status]) VALUES (1, N'Theory', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (2, N'Cartoon', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (3, N'Romance', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (4, N'Action', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (5, N'Family', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (6, N'Fiction', 1)
INSERT [dbo].[categories] ([id], [name], [status]) VALUES (7, N'18 +', 1)
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[movie_Actors] ON 

INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (21, 7, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (22, 7, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (23, 8, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (24, 8, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (25, 8, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (29, 9, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (30, 9, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (31, 9, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (32, 9, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (33, 9, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (34, 9, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (35, 10, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (36, 10, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (37, 10, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (38, 11, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (39, 11, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (40, 11, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (41, 11, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (42, 11, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (43, 12, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (44, 12, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (45, 12, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (46, 12, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (47, 13, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (48, 13, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (49, 13, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (50, 13, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (51, 13, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (52, 14, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (53, 14, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (54, 14, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (55, 15, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (56, 15, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (57, 15, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (58, 15, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (59, 15, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (60, 16, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (61, 16, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (62, 16, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (63, 16, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (64, 16, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (65, 17, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (66, 17, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (67, 17, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (68, 17, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (69, 17, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (70, 17, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (71, 18, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (72, 18, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (73, 18, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (74, 18, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (75, 18, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (76, 18, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (77, 19, 8)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (78, 19, 4)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (79, 19, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (80, 19, 6)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (81, 19, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (82, 19, 5)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (83, 19, 2)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (84, 20, 7)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (85, 20, 3)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (86, 20, 1)
INSERT [dbo].[movie_Actors] ([id], [movie_id], [actor_id]) VALUES (87, 20, 8)
SET IDENTITY_INSERT [dbo].[movie_Actors] OFF
GO
SET IDENTITY_INSERT [dbo].[movie_Categories] ON 

INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (13, 2, 7)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (14, 6, 7)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (15, 7, 8)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (16, 4, 8)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (20, 6, 9)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (21, 7, 9)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (22, 4, 9)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (23, 1, 10)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (24, 6, 10)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (25, 6, 11)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (26, 3, 11)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (27, 4, 11)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (28, 4, 12)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (29, 1, 12)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (30, 7, 12)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (31, 1, 13)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (32, 7, 13)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (33, 4, 13)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (34, 6, 13)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (35, 4, 14)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (36, 1, 14)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (37, 6, 14)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (38, 3, 14)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (39, 4, 15)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (40, 6, 15)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (41, 7, 15)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (42, 1, 15)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (43, 4, 16)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (44, 1, 16)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (45, 7, 16)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (46, 6, 16)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (47, 3, 17)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (48, 6, 17)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (49, 4, 17)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (50, 6, 18)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (51, 2, 18)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (52, 1, 18)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (53, 2, 19)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (54, 6, 19)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (55, 4, 19)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (56, 3, 19)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (57, 1, 20)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (58, 6, 20)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (59, 7, 20)
INSERT [dbo].[movie_Categories] ([id], [category_id], [movie_id]) VALUES (60, 3, 20)
SET IDENTITY_INSERT [dbo].[movie_Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[movies] ON 

INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (6, N'GODZILLA vs. KONG (2021)', N'new series 2021', N'ELni2ZtivQE', 2, 124, CAST(N'2021-01-15T12:16:00.0000000' AS DateTime2), N'https://i.pinimg.com/originals/0e/bf/8d/0ebf8d713b883e18d07fad91b0ef095b.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (7, N'Minion - The rise of Gru', N'In the heart of the 1970s, amid a flurry of feathered hair and flared jeans, Gru (Oscar® nominee Steve Carell) is growing up in the suburbs. A fanboy of a supervillain supergroup known as the Vicious 6, Gru hatches a plan to become evil enough to join them. Luckily, he gets some mayhem-making backup from his loyal followers, the Minions. Together, Kevin, Stuart, Bob, and Otto—a new Minion sporting braces and a desperate need to please—deploy their skills as they and Gru build their first lair, experiment with their first weapons and pull off their first missions. When the Vicious 6 oust their leader, legendary fighter Wild Knuckles (Oscar® winner Alan Arkin), Gru interviews to become their newest member. It doesn’t go well (to say the least), and only gets worse after Gru outsmarts them and suddenly finds himself the mortal enemy of the apex of evil. On the run, Gru will turn to an unlikely source for guidance, Wild Knuckles himself, and discover that even bad guys need a little help from their friends. ', N'3Y9XeruN5RY', 2, 123, CAST(N'2021-01-22T13:27:00.0000000' AS DateTime2), N'https://images-na.ssl-images-amazon.com/images/I/71Fzm85rLfL._AC_SL1353_.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (8, N'Loki', N'“Glorious.”
Loki, an Original Series from Marvel Studios, is coming May 2021 to #DisneyPlus.', N'G4JuopziR3Q', 2, 123, CAST(N'2021-01-30T13:41:00.0000000' AS DateTime2), N'data:image/jpeg;base64,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')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (9, N'Venom 2 Let There Be Carnage', N'Venom2: Let There Be Carnage is an upcoming American superhero film based on the Marvel Comics character Venom, produced by Columbia Pictures in association with Marvel and Tencent Pictures. The film is being directed by Andy Serkis from a screenplay by Kelly Marcel, and stars Tom Hardy as Eddie Brock / Venom alongside Woody Harrelson, Michelle Williams, Reid Scott, and Naomie Harris.

During the long development of the 2018 film Venom, the character Carnage was expected to appear as an antagonist. During pre-production on that film, the creative team decided not to include the character so they could focus on introducing the protagonists, Eddie Brock and Venom. Director Ruben Fleischer felt that leaving Venom''s most formidable villain for a sequel would give the franchise "a place to go" and would be a natural next step,Venom 2, Venom 2 trailer, Venom 2 teaser trailer, Venom 2 official trailer, so Carnage''s alter-ego Cletus Kasady was introduced in a mid-credits scene at the end of the first film with the intention of featuring him in a sequel. Fleischer wanted to cast Woody Harrelson in the role, feeling there was a "natural connection" between the character and Harrelson''s performance in Natural Born Killers (1994),  and asked Harrelson while the pair were discussing a sequel to their film Zombieland (2009).Venom 2 movie, Venom 2 Let There Be Carnage, Venom 2 Let There Be Carnage trailer, Venom 2 Let There Be Carnage teaser trailer, After meeting with Fleischer and Tom Hardy—who portrays Brock and Venom—for dinner, Harrelson agreed to take on the part.Harrelson described his decision as a roll of the dice since he was unable to read a script for the sequel before signing on to the first film. In August 2018, ahead of Venom''s release, Hardy confirmed that he had signed on to star in two sequels.

At the end of November 2018, Sony gave an October 2, 2020 release date to an untitled Marvel sequel that was believed to be Venom 2, which would place the film in the same release timeframe as the first Venom; box office analysts believed by then that Venom had been successful enough to guarantee a sequel would be made.Venom 2 Let There Be Carnageofficial trailer, Venom Let There Be Carnage, Venom Let There Be Carnage trailer,A month later, Venom writer Jeff Pinkner confirmed that a sequel was "happening", but he was not involved in writing it at that point. Fleischer reiterated this, saying that he could not discuss a sequel but he saw the first film as Brock and Venom "coming together. So there’s a natural evolution from that to [a sequel where it is like, okay, now what’s it like to live together?Venom 2021, Let There Be Carnage, Let There Be Carnage trailer, venom 2 carnage, venom 2 carnage trailer, venom 2 carnage official trailer, It’s like a bromantic sort of relationship." In January, Kelly Marcel signed a "significant" deal with Sony to write and executive produce the sequel after also working on the script for the first film. venom 2 carnage teaser,
 Venom 2 First Trailer, Spider-Man 3 Homesick, Spider-Man Homesick trailer, Spider-Man 3 Homesick teaser trailer,This marked the official beginning of work on the film for the studio, and was revealed alongside confirmation of Avi Arad, Matt Tolmach, and Amy Pascal returning as producers. Hardy and Harrelson were also expected to return for the sequel, along with Michelle Williams in the role of Brock''s ex-fiancée Anne Weying.Spiderman 3 official trailer, Spiderman 3 trailer, SpiderVerse, SpiderVerse trailer, Avengers 5, Avengers 5 trailer, Marvel trailer No director was confirmed for the film, with Sony considering replacing Fleischer due to his commitments to Zombieland: Double Tap (2019), though he still intended to be involved in Venom 2.', N'kYeGOBiOQK0', 2, 221, CAST(N'2021-01-15T13:38:00.0000000' AS DateTime2), N'https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/63865396030787.5ea55cf4e5e25.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (10, N'TOP GUN 2: Maverick', N'After more than thirty years of service as one of the Navy’s top aviators, Pete “Maverick” Mitchell (Tom Cruise) is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him. When he finds himself training a detachment of Top Gun graduates for a specialized mission the likes of which no living pilot has ever seen, Maverick encounters Lt. Bradley Bradshaw (Miles Teller), call sign: “Rooster,” the son of Maverick’s late friend and Radar Intercept Officer Lt. Nick Bradshaw, aka “Goose.” Facing an uncertain future and confronting the ghosts of his past, Maverick is drawn into a confrontation with his own deepest fears, culminating in a mission that demands the ultimate sacrifice from those who will be chosen to fly it.', N'HpZgwHU1GcI', 2, 210, CAST(N'2021-01-01T13:41:00.0000000' AS DateTime2), N'https://images-na.ssl-images-amazon.com/images/I/81g5mv8iBxL._AC_SL1500_.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (11, N'FAST AND FURIOUS 9', N'No matter how fast you are, no one outruns their past. 

Summer 2020 is the time for F9, the ninth chapter in the saga that has endured for almost two decades and has earned more than $5 billion around the world.  

Vin Diesel’s Dom Toretto is leading a quiet life off the grid with Letty and his son, little Brian, but they know that danger always lurks just over their peaceful horizon. This time, that threat will force Dom to confront the sins of his past if he’s going to save those he loves most. His crew joins together to stop a world-shattering plot led by the most skilled assassin and high-performance driver they’ve ever encountered: a man who also happens to be Dom’s forsaken brother, Jakob (John Cena, next year’s The Suicide Squad). 

F9 sees the return of Justin Lin as director, who helmed the third, fourth, fifth and sixth chapters of the series when it transformed into a global blockbuster. The action hurtles around the globe—from London to Tokyo, from Central America to Edinburgh, and from a secret bunker in Azerbaijan to the teeming streets of Tblisi. Along the way, old friends will be resurrected, old foes will return, history will be rewritten, and the true meaning of family will be tested like never before.  

The film stars returning cast members Michelle Rodriguez, Tyrese Gibson, Chris “Ludacris” Bridges, Jordana Brewster, Nathalie Emmanuel and Sung Kang, with Oscar® winner Helen Mirren and Oscar® winner Charlize Theron. F9 also features Grammy-winning superstar Cardi B as new franchise character Leysa, a woman with a connection to Dom’s past, and a cameo by Reggaeton sensation Ozuna.  

F9 is produced by Neal H. Moritz, Vin Diesel, Jeff Kirschenbaum, Joe Roth, Justin Lin, Clayton Townsend and Samantha Vincent.', N'FUK2kdPsBws', 2, 185, CAST(N'2021-05-20T13:41:00.0000000' AS DateTime2), N'https://images-na.ssl-images-amazon.com/images/I/71dY%2BAWVyJL._AC_SL1500_.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (12, N'The New Mutants', N'20th Century Fox in association with Marvel Entertainment presents “The New Mutants,” an original horror thriller set in an isolated hospital where a group of young mutants is being held for psychiatric monitoring. When strange occurrences begin to take place, both their new mutant abilities and their friendships will be tested as they battle to try and make it out alive.
', N'W_vJhUAOFpI', 2, 178, CAST(N'2021-05-20T13:41:00.0000000' AS DateTime2), N'https://images-na.ssl-images-amazon.com/images/I/81hdGuRz8kL._AC_SY679_.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (13, N'Wonder Woman 1984', N'Fast forward to the 1980s as Wonder Woman’s next big screen adventure finds her facing two all-new foes: Max Lord and The Cheetah.  
 
With director Patty Jenkins back at the helm and Gal Gadot returning in the title role, “Wonder Woman 1984” is Warner Bros. Pictures’ follow up to the DC Super Hero’s first outing, 2017’s record-breaking “Wonder Woman,” which took in $822 million at the worldwide box office.  The film also stars Chris Pine as Steve Trevor, Kristen Wiig as The Cheetah, Pedro Pascal as Max Lord, Robin Wright as Antiope, and Connie Nielsen as Hippolyta.
 
Charles Roven, Deborah Snyder, Zack Snyder, Patty Jenkins, Gal Gadot and Stephen Jones are producing the film.  Rebecca Steel Roven Oakley, Richard Suckle, Marianne Jenkins, Geoff Johns, Walter Hamada, Chantal Nong Vo and Wesley Coller are the executive producers.
 
Patty Jenkins directed from a screenplay she wrote with Geoff Johns & David Callaham, story by Jenkins & Johns, based on characters from DC.  Joining the director behind the scenes are several members of her “Wonder Woman” team, including director of photography Matthew Jensen, Oscar-nominated production designer Aline Bonetto (“Amélie”), and Oscar-winning costume designer Lindy Hemming (“Topsy-Turvy”).  Oscar-nominated editor Richard Pearson (“United 93”) is cutting the film.  The music is by Oscar-winning composer Hans Zimmer (“Dunkirk,” “The Lion King”).
 
Warner Bros. Pictures Presents an Atlas Entertainment/Stone Quarry Production, a Patty Jenkins Film, “Wonder Woman 1984.”  Set to open in theaters in 2D and 3D in select theaters and IMAX, it will be distributed worldwide by Warner Bros. Pictures.
 
This film is rated PG-13 for sequences of action and violence.', N'XW2E2Fnh52w', 2, 104, CAST(N'2022-01-18T13:41:00.0000000' AS DateTime2), N'https://i.pinimg.com/originals/ce/e9/c9/cee9c9b3f9764ec4efca30b3e0d7e356.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (14, N'Black Widow', N'Fast forward to the 1980s as Wonder Woman’s next big screen adventure finds her facing two all-new foes: Max Lord and The Cheetah.  
 
With director Patty Jenkins back at the helm and Gal Gadot returning in the title role, “Wonder Woman 1984” is Warner Bros. Pictures’ follow up to the DC Super Hero’s first outing, 2017’s record-breaking “Wonder Woman,” which took in $822 million at the worldwide box office.  The film also stars Chris Pine as Steve Trevor, Kristen Wiig as The Cheetah, Pedro Pascal as Max Lord, Robin Wright as Antiope, and Connie Nielsen as Hippolyta.
 
Charles Roven, Deborah Snyder, Zack Snyder, Patty Jenkins, Gal Gadot and Stephen Jones are producing the film.  Rebecca Steel Roven Oakley, Richard Suckle, Marianne Jenkins, Geoff Johns, Walter Hamada, Chantal Nong Vo and Wesley Coller are the executive producers.
 
Patty Jenkins directed from a screenplay she wrote with Geoff Johns & David Callaham, story by Jenkins & Johns, based on characters from DC.  Joining the director behind the scenes are several members of her “Wonder Woman” team, including director of photography Matthew Jensen, Oscar-nominated production designer Aline Bonetto (“Amélie”), and Oscar-winning costume designer Lindy Hemming (“Topsy-Turvy”).  Oscar-nominated editor Richard Pearson (“United 93”) is cutting the film.  The music is by Oscar-winning composer Hans Zimmer (“Dunkirk,” “The Lion King”).
 
Warner Bros. Pictures Presents an Atlas Entertainment/Stone Quarry Production, a Patty Jenkins Film, “Wonder Woman 1984.”  Set to open in theaters in 2D and 3D in select theaters and IMAX, it will be distributed worldwide by Warner Bros. Pictures.
 
This film is rated PG-13 for sequences of action and violence.', N'ybji16u608U', 1, 125, CAST(N'2022-01-16T13:41:00.0000000' AS DateTime2), N'https://images-na.ssl-images-amazon.com/images/I/914MHuDfMSL.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (15, N'THE BATMAN', N'From Warner Bros. Pictures comes “The Batman,” with director Matt Reeves (the “Planet of the Apes” films) at the helm and with Robert Pattinson (“Tenet,” “The Lighthouse,” “Good Time”) starring as Gotham City’s vigilante detective, Batman, and billionaire Bruce Wayne.

Also in the star-studded ensemble as Gotham’s famous and infamous cast of characters are Zoë Kravitz (“Fantastic Beasts: The Crimes of Grindelwald,” “Mad Max: Fury Road”) as Selina Kyle; Paul Dano (“Love & Mercy,” “12 Years a Slave”) as Edward Nashton; Jeffrey Wright (the “Hunger Games” films) as the GCPD’s James Gordon; John Turturro (the “Transformers” films) as Carmine Falcone; Peter Sarsgaard (“The Magnificent Seven,” “Black Mass”) as Gotham D.A. Gil Colson; Barry Keoghan (“Dunkirk”) as Officer Stanley Merkel; Jayme Lawson (“Farewell Amor”) as mayoral candidate Bella Reál; with Andy Serkis (the “Planet of the Apes” films, “Black Panther”) as Alfred; and Colin Farrell (“Fantastic Beasts and Where to Find Them,” “Dumbo”) as Oswald Cobblepot.

“The Batman” was written by Matt Reeves & Peter Craig.  Reeves and Dylan Clark (the “Planet of the Apes” films) are producing the film, with Simon Emanuel, Michael E. Uslan, Walter Hamada and Chantal Nong Vo serving as executive producers.  Reeves’ behind-the-scenes creative team includes Oscar-nominated director of photography Greig Fraser (“Lion,” upcoming “Dune”); his “Planet of the Apes” production designer, James Chinlund; editors William Hoy (the “Planet of the Apes” films) and Tyler Nelson (“Rememory”); Oscar-winning VFX supervisor Dan Lemmon (“The Jungle Book”); Oscar-nominated SFX supervisor Dominic Tuohy (“1917,” “Star Wars: Episode IX – The Rise of Skywalker”); Oscar-nominated sound mixer Stuart Wilson (“1917,” the “Star Wars” franchise); Oscar-winning costume designer Jacqueline Durran (“1917,” “Little Women,” “Anna Karenina”) and costume designers Glyn Dillon (the “Star Wars” franchise) and David Crossman (“1917,” the “Star Wars” franchise); hair designer Zoe Tahir (upcoming “No Time to Die,” “Spectre”); and Oscar-nominated makeup designer Naomi Donne (“1917”).

Based on characters from DC.  Batman was created by Bob Kane with Bill Finger.  “The Batman” is set to open in theaters October 1, 2021 in select 3D and 2D and IMAX theaters and will be distributed worldwide by Warner Bros. Pictures.', N'NLOp_6uPccQ', 1, 212, CAST(N'2022-03-12T13:41:00.0000000' AS DateTime2), N'data:image/jpeg;base64,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')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (16, N'NO TIME TO DIE', N'In No Time To Die, Bond has left active service and is enjoying a tranquil life in Jamaica. His peace is short-lived when his old friend Felix Leiter from the CIA turns up asking for help. The mission to rescue a kidnapped scientist turns out to be far more treacherous than expected, leading Bond onto the trail of a mysterious villain armed with dangerous new technology. ', N'BIhNsAtPbPI', 2, 105, CAST(N'2022-06-27T13:41:00.0000000' AS DateTime2), N'https://cdnmedia.thethaovanhoa.vn/Upload/leenEplQKY7jsunvYUYgg/files/2020/01/craig1.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (17, N'Jungle Cruise', N'all new movie trailers from Jungle Cruise Starring Dwayne Johnson in 4K ULTRA HD Quality

Jungle Cruise is an upcoming American adventure film directed by Jaume Collet-Serra from a screen story by Josh Goldstein & John Norville and Glenn Ficarra & John Requa and a screenplay written by Michael Green, Ficarra and Requa, based on Walt Disney''s theme park attraction of the same name. Produced by Walt Disney Pictures, the film stars Dwayne Johnson, Emily Blunt, Édgar Ramírez, Jack Whitehall, Jesse Plemons, and Paul Giamatti.

Plot : Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon in his ramshackle boat. Together, they search for an ancient tree that holds the power to heal -- a discovery that will change the future of medicine.', N'9fZrBf8wmZI', 2, 235, CAST(N'2022-12-10T13:41:00.0000000' AS DateTime2), N'https://m.media-amazon.com/images/M/MV5BZWFiZTM4ZDUtNzU0My00YmYxLWEzMDQtNzkxMzJhYmNiMTE3XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (18, N'Rumble', N'In a world where monsters are tame and monster wrestling is a popular sport, Winnie seeks to follow in her father''s footsteps as a manager by turning an inexperienced monster into a contender.

Rumble (2021) is the new animation movie starring Will Arnett, Terry Crews and Geraldine Viswanathan.', N'QbE5JpYWhGk', 1, 90, CAST(N'2022-10-05T13:41:00.0000000' AS DateTime2), N'data:image/jpeg;base64,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')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (19, N'Peter Rabbit 2 The Runaway', N'In PETER RABBIT™ 2: THE RUNAWAY, the lovable rogue is back.  Bea, Thomas, and the rabbits have created a makeshift family, but despite his best efforts, Peter can’t seem to shake his mischievous reputation. Adventuring out of the garden, Peter finds himself in a world where his mischief is appreciated, but when his family risks everything to come looking for him, Peter must figure out what kind of bunny he wants to be.', N'PWBcqCz7l_c', 1, 211, CAST(N'2022-09-26T13:41:00.0000000' AS DateTime2), N'https://cmavn.org/wp-content/uploads/2019/10/1566080553-peter-ra.jpg')
INSERT [dbo].[movies] ([id], [name], [summery], [trailer_path], [status], [duration], [published_date], [poster]) VALUES (20, N'SAW: Spiral', N'Movie Trailer | Release: 21 May 2021 | More https://KinoCheck.com/film/sjj/spiral...
A sadistic mastermind unleashes a twisted form of justice in SPIRAL, the terrifying new chapter from the book of SAW. Working in the shadow of an esteemed police veteran (Samuel L. Jackson), brash Detective Ezekiel “Zeke” Banks (Chris Rock) and his rookie partner (Max Minghella) take charge of a grisly investigation into murders that are eerily reminiscent of the city’s gruesome past. Unwittingly entrapped in a deepening mystery, Zeke finds himself at the center of the killer’s morbid game.

Spiral: From the Book of Saw (2021) is the new horror movie starring Chris Rock, Samuel L. Jackson and Max Minghella.', N'L5pgwURxuNs', 1, 217, CAST(N'2021-01-05T14:11:00.0000000' AS DateTime2), N'https://www.joblo.com/assets/images/joblo/posters/2020/03/220CE870-1CD1-473D-AF88-32B6F558E0C0.jpeg')
SET IDENTITY_INSERT [dbo].[movies] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [user_id], [total_price], [status], [create_date]) VALUES (1, 3, 150, 1, CAST(N'2020-01-04T13:00:00.0000000' AS DateTime2))
INSERT [dbo].[orders] ([id], [user_id], [total_price], [status], [create_date]) VALUES (2, 3, 100, 1, CAST(N'2020-01-02T14:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[rooms] ON 

INSERT [dbo].[rooms] ([id], [branch_id], [name], [status]) VALUES (1, 1, N'room 1', 1)
INSERT [dbo].[rooms] ([id], [branch_id], [name], [status]) VALUES (2, 3, N'room 1', 1)
INSERT [dbo].[rooms] ([id], [branch_id], [name], [status]) VALUES (3, 1, N'room 2', 1)
SET IDENTITY_INSERT [dbo].[rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[schedules] ON 

INSERT [dbo].[schedules] ([id], [room_id], [movie_id], [start_time]) VALUES (1, 1, 7, CAST(N'2021-12-08T13:00:00.0000000' AS DateTime2))
INSERT [dbo].[schedules] ([id], [room_id], [movie_id], [start_time]) VALUES (2, 2, 6, CAST(N'2021-12-08T07:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[schedules] OFF
GO
SET IDENTITY_INSERT [dbo].[seat_status] ON 

INSERT [dbo].[seat_status] ([id], [seat_id], [ticket_id], [status]) VALUES (1, 1, 1, 1)
INSERT [dbo].[seat_status] ([id], [seat_id], [ticket_id], [status]) VALUES (2, 2, 2, 1)
INSERT [dbo].[seat_status] ([id], [seat_id], [ticket_id], [status]) VALUES (3, 30, 3, 1)
INSERT [dbo].[seat_status] ([id], [seat_id], [ticket_id], [status]) VALUES (4, 34, 4, 1)
INSERT [dbo].[seat_status] ([id], [seat_id], [ticket_id], [status]) VALUES (5, 40, 5, 1)
SET IDENTITY_INSERT [dbo].[seat_status] OFF
GO
SET IDENTITY_INSERT [dbo].[seats] ON 

INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (1, 1, N'0')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (2, 1, N'1')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (3, 1, N'2')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (4, 1, N'3')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (5, 1, N'4')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (6, 1, N'5')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (7, 1, N'6')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (8, 1, N'7')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (9, 1, N'8')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (10, 1, N'9')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (11, 1, N'10')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (12, 1, N'11')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (13, 1, N'12')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (14, 1, N'13')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (15, 1, N'14')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (16, 1, N'15')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (17, 1, N'16')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (18, 1, N'17')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (19, 1, N'18')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (20, 1, N'19')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (21, 1, N'20')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (22, 1, N'21')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (23, 1, N'22')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (24, 1, N'23')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (25, 1, N'24')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (26, 1, N'25')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (27, 1, N'26')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (28, 1, N'27')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (30, 2, N'0')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (31, 2, N'1')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (32, 2, N'2')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (33, 2, N'3')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (34, 2, N'4')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (35, 2, N'5')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (36, 2, N'6')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (37, 2, N'7')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (38, 2, N'8')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (39, 2, N'9')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (40, 2, N'10')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (41, 2, N'11')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (42, 2, N'12')
INSERT [dbo].[seats] ([id], [room_id], [position]) VALUES (43, 2, N'13')
SET IDENTITY_INSERT [dbo].[seats] OFF
GO
SET IDENTITY_INSERT [dbo].[tickets] ON 

INSERT [dbo].[tickets] ([id], [order_id], [schedule_id], [price], [Roomid]) VALUES (1, 1, 1, 50, NULL)
INSERT [dbo].[tickets] ([id], [order_id], [schedule_id], [price], [Roomid]) VALUES (2, 1, 1, 50, NULL)
INSERT [dbo].[tickets] ([id], [order_id], [schedule_id], [price], [Roomid]) VALUES (3, 1, 1, 50, NULL)
INSERT [dbo].[tickets] ([id], [order_id], [schedule_id], [price], [Roomid]) VALUES (4, 2, 2, 50, NULL)
INSERT [dbo].[tickets] ([id], [order_id], [schedule_id], [price], [Roomid]) VALUES (5, 2, 2, 50, NULL)
SET IDENTITY_INSERT [dbo].[tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [password], [displayname], [email], [birthday], [avatar], [rule]) VALUES (2, N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'admin', N'admin@gmail.com', CAST(N'2000-06-23T00:00:00.0000000' AS DateTime2), N'', 1)
INSERT [dbo].[users] ([id], [username], [password], [displayname], [email], [birthday], [avatar], [rule]) VALUES (3, N'member', N'aa08769cdcb26674c6706093503ff0a3', N'member1', N'member@gmail.com', CAST(N'2001-04-12T00:00:00.0000000' AS DateTime2), NULL, 0)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
/****** Object:  Index [IX_contactForms_user_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_contactForms_user_id] ON [dbo].[contactForms]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_movie_Actors_actor_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_movie_Actors_actor_id] ON [dbo].[movie_Actors]
(
	[actor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_movie_Actors_movie_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_movie_Actors_movie_id] ON [dbo].[movie_Actors]
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_movie_Categories_category_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_movie_Categories_category_id] ON [dbo].[movie_Categories]
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_movie_Categories_movie_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_movie_Categories_movie_id] ON [dbo].[movie_Categories]
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Movie_Discount_discount_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_Movie_Discount_discount_id] ON [dbo].[Movie_Discount]
(
	[discount_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Movie_Discount_movie_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_Movie_Discount_movie_id] ON [dbo].[Movie_Discount]
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_orders_user_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_orders_user_id] ON [dbo].[orders]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_reports_review_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_reports_review_id] ON [dbo].[reports]
(
	[review_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_reviews_movie_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_reviews_movie_id] ON [dbo].[reviews]
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_reviews_user_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_reviews_user_id] ON [dbo].[reviews]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_rooms_branch_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_rooms_branch_id] ON [dbo].[rooms]
(
	[branch_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_schedules_movie_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_schedules_movie_id] ON [dbo].[schedules]
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_schedules_room_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_schedules_room_id] ON [dbo].[schedules]
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_seat_status_seat_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_seat_status_seat_id] ON [dbo].[seat_status]
(
	[seat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_seat_status_ticket_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_seat_status_ticket_id] ON [dbo].[seat_status]
(
	[ticket_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_seats_room_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_seats_room_id] ON [dbo].[seats]
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tickets_order_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_tickets_order_id] ON [dbo].[tickets]
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tickets_Roomid]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_tickets_Roomid] ON [dbo].[tickets]
(
	[Roomid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tickets_schedule_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_tickets_schedule_id] ON [dbo].[tickets]
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_userDiscounts_discount_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_userDiscounts_discount_id] ON [dbo].[userDiscounts]
(
	[discount_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_userDiscounts_user_id]    Script Date: 1/6/2021 11:50:33 AM ******/
CREATE NONCLUSTERED INDEX [IX_userDiscounts_user_id] ON [dbo].[userDiscounts]
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[contactForms]  WITH CHECK ADD  CONSTRAINT [FK_contactForms_users_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[contactForms] CHECK CONSTRAINT [FK_contactForms_users_user_id]
GO
ALTER TABLE [dbo].[movie_Actors]  WITH CHECK ADD  CONSTRAINT [FK_movie_Actors_actors_actor_id] FOREIGN KEY([actor_id])
REFERENCES [dbo].[actors] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movie_Actors] CHECK CONSTRAINT [FK_movie_Actors_actors_actor_id]
GO
ALTER TABLE [dbo].[movie_Actors]  WITH CHECK ADD  CONSTRAINT [FK_movie_Actors_movies_movie_id] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movie_Actors] CHECK CONSTRAINT [FK_movie_Actors_movies_movie_id]
GO
ALTER TABLE [dbo].[movie_Categories]  WITH CHECK ADD  CONSTRAINT [FK_movie_Categories_categories_category_id] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movie_Categories] CHECK CONSTRAINT [FK_movie_Categories_categories_category_id]
GO
ALTER TABLE [dbo].[movie_Categories]  WITH CHECK ADD  CONSTRAINT [FK_movie_Categories_movies_movie_id] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[movie_Categories] CHECK CONSTRAINT [FK_movie_Categories_movies_movie_id]
GO
ALTER TABLE [dbo].[Movie_Discount]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Discount_discounts_discount_id] FOREIGN KEY([discount_id])
REFERENCES [dbo].[discounts] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Movie_Discount] CHECK CONSTRAINT [FK_Movie_Discount_discounts_discount_id]
GO
ALTER TABLE [dbo].[Movie_Discount]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Discount_movies_movie_id] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Movie_Discount] CHECK CONSTRAINT [FK_Movie_Discount_movies_movie_id]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_users_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_users_user_id]
GO
ALTER TABLE [dbo].[reports]  WITH CHECK ADD  CONSTRAINT [FK_reports_reviews_review_id] FOREIGN KEY([review_id])
REFERENCES [dbo].[reviews] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[reports] CHECK CONSTRAINT [FK_reports_reviews_review_id]
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD  CONSTRAINT [FK_reviews_movies_movie_id] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[reviews] CHECK CONSTRAINT [FK_reviews_movies_movie_id]
GO
ALTER TABLE [dbo].[reviews]  WITH CHECK ADD  CONSTRAINT [FK_reviews_users_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[reviews] CHECK CONSTRAINT [FK_reviews_users_user_id]
GO
ALTER TABLE [dbo].[rooms]  WITH CHECK ADD  CONSTRAINT [FK_rooms_branches_branch_id] FOREIGN KEY([branch_id])
REFERENCES [dbo].[branches] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[rooms] CHECK CONSTRAINT [FK_rooms_branches_branch_id]
GO
ALTER TABLE [dbo].[schedules]  WITH CHECK ADD  CONSTRAINT [FK_schedules_movies_movie_id] FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules] CHECK CONSTRAINT [FK_schedules_movies_movie_id]
GO
ALTER TABLE [dbo].[schedules]  WITH CHECK ADD  CONSTRAINT [FK_schedules_rooms_room_id] FOREIGN KEY([room_id])
REFERENCES [dbo].[rooms] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[schedules] CHECK CONSTRAINT [FK_schedules_rooms_room_id]
GO
ALTER TABLE [dbo].[seat_status]  WITH CHECK ADD  CONSTRAINT [FK_seat_status_seats_seat_id] FOREIGN KEY([seat_id])
REFERENCES [dbo].[seats] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[seat_status] CHECK CONSTRAINT [FK_seat_status_seats_seat_id]
GO
ALTER TABLE [dbo].[seat_status]  WITH CHECK ADD  CONSTRAINT [FK_seat_status_tickets_ticket_id] FOREIGN KEY([ticket_id])
REFERENCES [dbo].[tickets] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[seat_status] CHECK CONSTRAINT [FK_seat_status_tickets_ticket_id]
GO
ALTER TABLE [dbo].[seats]  WITH CHECK ADD  CONSTRAINT [FK_seats_rooms_room_id] FOREIGN KEY([room_id])
REFERENCES [dbo].[rooms] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[seats] CHECK CONSTRAINT [FK_seats_rooms_room_id]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_orders_order_id] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_orders_order_id]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_rooms_Roomid] FOREIGN KEY([Roomid])
REFERENCES [dbo].[rooms] ([id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_rooms_Roomid]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_schedules_schedule_id] FOREIGN KEY([schedule_id])
REFERENCES [dbo].[schedules] ([id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_schedules_schedule_id]
GO
ALTER TABLE [dbo].[userDiscounts]  WITH CHECK ADD  CONSTRAINT [FK_userDiscounts_discounts_discount_id] FOREIGN KEY([discount_id])
REFERENCES [dbo].[discounts] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[userDiscounts] CHECK CONSTRAINT [FK_userDiscounts_discounts_discount_id]
GO
ALTER TABLE [dbo].[userDiscounts]  WITH CHECK ADD  CONSTRAINT [FK_userDiscounts_users_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[userDiscounts] CHECK CONSTRAINT [FK_userDiscounts_users_user_id]
GO
USE [master]
GO
ALTER DATABASE [boleto_db] SET  READ_WRITE 
GO

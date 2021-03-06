USE [master]

GO
/****** Object:  Database [KontorsprylarAB]    Script Date: 2017-03-24 22:28:56 ******/
CREATE DATABASE [KontorsprylarAB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KontorsprylarAB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\KontorsprylarAB.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KontorsprylarAB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\KontorsprylarAB_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KontorsprylarAB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KontorsprylarAB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KontorsprylarAB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KontorsprylarAB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KontorsprylarAB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KontorsprylarAB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KontorsprylarAB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET RECOVERY FULL 
GO
ALTER DATABASE [KontorsprylarAB] SET  MULTI_USER 
GO
ALTER DATABASE [KontorsprylarAB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KontorsprylarAB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KontorsprylarAB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KontorsprylarAB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [KontorsprylarAB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KontorsprylarAB', N'ON'
GO
USE [KontorsprylarAB]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[ArticleID] [int] IDENTITY(2001,1) NOT NULL,
	[ArticleName] [nvarchar](50) NOT NULL,
	[ArticlePrice] [money] NOT NULL,
	[ArticleCategory] [nvarchar](50) NOT NULL,
	[ArticleDescription] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsInStock] [bit] NOT NULL,
	[ArticleImage] [nvarchar](max)
PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(3005,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserPassword] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[Zip] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[CountryCode] [nvarchar](2) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailsID] [int] IDENTITY(1001,1) NOT NULL,
	[OrderHeadID] [int] NULL,
	[ArticleID] [int] NULL,
	[Price] [money] NOT NULL,
	[NumberOfArticles] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderHead]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHead](
	[OrderHeadID] [int] IDENTITY(1001,1) NOT NULL,
	[CustomerID] [int] NULL,
	[Discount] [decimal](18, 0) NOT NULL,
	[OrderDate] [nvarchar](50) NOT NULL,
	[OrderStatus] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderHeadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ArticleID])
REFERENCES [dbo].[Article] ([ArticleID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([OrderHeadID])
REFERENCES [dbo].[OrderHead] ([OrderHeadID])
GO
ALTER TABLE [dbo].[OrderHead]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[AddCustomer]
	@username varchar(50), 
	@userpassword varchar(50), 
	@firstname varchar(50), 
	@lastname varchar(50), 
	@street varchar(50), 
	@zip varchar(50), 
	@city varchar(50), 
	@countrycode varchar(50), 
	@email varchar(50), 
	@phonenumber varchar(50), 
	@isadmin bit, 
	@isactive bit, 
	@customer_id int output

	AS
	insert into Customer (UserName, UserPassword, FirstName, LastName, Street, Zip, City, CountryCode, Email, PhoneNumber, IsAdmin, IsActive) 
	values (@username, @userpassword, @firstname, @lastname, @street, @zip, @city, @countrycode, @email, @phonenumber, @isadmin, @isactive) 
	set @customer_id = scope_identity() 
	

GO
/****** Object:  StoredProcedure [dbo].[CreateArticle]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CreateArticle]

@ArticleName nvarchar(50),
@ArticlePrice money,
@ArticleCategory nvarchar(50),
@ArticleDescription nvarchar(max),
@IsActive bit,
@IsInStock bit,	
@ArticleID int output,
@ArticleImage nvarchar(max)

AS

INSERT INTO Article (ArticleName, ArticlePrice, ArticleCategory, ArticleDescription, IsActive, IsInStock, ArticleImage) VALUES (@ArticleName, @ArticlePrice, @ArticleCategory, @ArticleDescription, @IsActive, @IsInStock, @ArticleImage)

SET @ArticleID = SCOPE_IDENTITY()



GO
/****** Object:  StoredProcedure [dbo].[CreateOrderDetails]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[CreateOrderDetails]
@OrderHeadID int,
@ArticleID int,
@Price money,
@NumberOfArticles int

AS

	INSERT INTO OrderDetails(OrderHeadID, ArticleID, Price, NumberOfArticles) VALUES (@OrderHeadID, @ArticleID, @Price, @NumberOfArticles)

GO
/****** Object:  StoredProcedure [dbo].[CreateOrderHead]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CreateOrderHead]
@CustomerID int,
@Discount decimal,
@OrderDate nvarchar(50),
@OrderStatus nvarchar(50),
@OrderHeadID int output


AS
BEGIN
	insert into OrderHead(CustomerID, Discount, OrderDate, OrderStatus) values (@CustomerID, @Discount, @OrderDate, @OrderStatus)
	set @OrderHeadID = SCOPE_IDENTITY() 
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateArticle]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateArticle]

@ArticleID int,
@ArticleName nvarchar(50),
@ArticlePrice money,
@ArticleCategory nvarchar(50),
@ArticleDescription nvarchar(max),
@IsActive bit,
@IsInStock bit,
@ArticleImage nvarchar(max)

AS

UPDATE Article

set 
ArticleName = @ArticleName, 
ArticlePrice =  @ArticlePrice, 
ArticleCategory =  @ArticleCategory, 
ArticleDescription =  @ArticleDescription, 
IsActive = @IsActive, 
IsInStock = @IsInStock,
ArticleImage = @ArticleImage

where ArticleID = @ArticleID;



GO
/****** Object:  StoredProcedure [dbo].[UpdateOrderHead]    Script Date: 2017-03-24 22:28:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateOrderHead]
@OrderHeadID int,
@CustomerID int,
@Discount decimal,
@OrderDate nvarchar(50),
@OrderStatus nvarchar(50)

AS
BEGIN
	insert into OrderHead(OrderHeadID, CustomerID, Discount, OrderDate, OrderStatus) values (@OrderHeadID, @CustomerID, @Discount, @OrderDate, @OrderStatus)
END


GO
CREATE PROCEDURE [dbo].[SearchArticleByID]

	@FindArticleByID int

AS

SELECT * FROM Article
WHERE ArticleID = @FindArticleByID
GO
/****** Object:  StoredProcedure [dbo].[SearchArticleByName]    Script Date: 2017-03-25 15:18:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchArticleByName]

	@FindArticleByName nvarchar(50)

AS

SELECT * FROM Article
WHERE ArticleName like @FindArticleByName

OR ArticleCategory like @FindArticleByName

OR ArticleDescription like @FindArticleByName


GO
/****** Object:  StoredProcedure [dbo].[UpdateArticle]    Script Date: 2017-03-25 15:18:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO
ALTER DATABASE [KontorsprylarAB] SET  READ_WRITE 
GO

USE [KontorsprylarAB]
GO
/****** Object:  StoredProcedure [dbo].[GetUserByID]    Script Date: 2017-03-28 16:01:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetUserByID]

	@FindUserByID int

AS

SELECT * FROM Customer
WHERE CustomerID = @FindUserByID

GO

USE [KontorsprylarAB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 2017-03-29 11:05:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]

@CustomerID int,
@UserName nvarchar(50),
@UserPassword nvarchar(50),
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Street nvarchar(50),
@Zip nvarchar(max),
@City nvarchar(max),
@CountryCode nvarchar(max),
@Email nvarchar(max),
@PhoneNumber nvarchar(max)

AS

UPDATE Customer

set 
UserName = @UserName,
UserPassword = @UserPassword, 
FirstName =  @FirstName, 
LastName =  @LastName, 
Street =  @Street, 
Zip = @Zip, 
City = @City,
CountryCode = @CountryCode,
Email = @Email,
PhoneNumber = @PhoneNumber

where CustomerID = @CustomerID;

GO

CREATE PROCEDURE SearchArticleByCategory

@FindArticleByCategory nvarchar(50)

AS

SELECT * FROM Article
WHERE ArticleCategory = @FindArticleByCategory

GO
IF NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME = N'Brand' AND TYPE = N'U')
BEGIN
	CREATE TABLE dbo.Brand
	(
		 BrandID			INT				IDENTITY(1,1)
		, BrandName			VARCHAR(500)	NOT NULL
		, Email				VARCHAR(50)
		, PhoneNumber		VARCHAR(20)	
		, [Address]			VARCHAR(MAX)	
		, Logo				VARBINARY		NULL
		, FSSAINo			VARCHAR(20)	
		, IsActive			BIT				DEFAULT 1
		, CreatedBY			INT
		, CreatedDate		DATETIME		DEFAULT GETDATE()
		, ModifiedBy		INT				NULL
		, ModifiedDate		DATETIME		NULL
	)
END

IF NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME = N'Products' AND TYPE = N'U')
BEGIN
	CREATE TABLE dbo.Products
	(
		 ProductID			INT				IDENTITY(1,1)
		, ProductName		VARCHAR(500)	
		, BrandID			INT				
		, Price				MONEY			DEFAULT 0
		, NetWeight			INT				DEFAULT 0
		, ManufacturingDate	DATETIME		NULL
		, ProductImage		VARBINARY		NULL
		, IsActive			BIT				DEFAULT 1
		, CreatedBY			INT
		, CreatedDate		DATETIME		DEFAULT GETDATE()
		, ModifiedBy		INT				NULL
		, ModifiedDate		DATETIME		NULL
	)
END

IF NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME = N'Users' AND TYPE = N'U')
BEGIN
	CREATE TABLE dbo.Users
	(
		 UserID				INT				IDENTITY(1,1)
		, FirstName			VARCHAR(100)
		, LastName			VARCHAR(100)	NULL
		, UserName			VARCHAR(500)
		, [Password]		VARCHAR(500)	NULL
		, PhoneNumber		VARCHAR(50)				
		, Email				VARCHAR(50)		NULL
		, NetWeight			INT				DEFAULT 0
		, ManufacturingDate	DATETIME		NULL
		, ProductImage		VARBINARY		NULL
		, IsActive			BIT				DEFAULT 1
		, CreatedBY			INT
		, CreatedDate		DATETIME		DEFAULT GETDATE()
		, ModifiedBy		INT				NULL
		, ModifiedDate		DATETIME		NULL)
END
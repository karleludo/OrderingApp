USE [OrderingAppDBSQLmanage]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CategoryDescription] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[OrderTotalPrice] [float] NOT NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLine]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLine](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderLine] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[StockQuantity] [smallint] NOT NULL,
	[ImageByte] [varbinary](max) NULL,
	[CategoryId] [int] NOT NULL,
	[inStock] [bit] NOT NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK__Product__B40CC6CD4D706EDD] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_StockQuantity]  DEFAULT ((0)) FOR [StockQuantity]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_inStock]  DEFAULT ((0)) FOR [inStock]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Order]
GO
ALTER TABLE [dbo].[OrderLine]  WITH CHECK ADD  CONSTRAINT [FK_OrderLine_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderLine] CHECK CONSTRAINT [FK_OrderLine_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [CK_StockQuantityLimit] CHECK  (([StockQuantity]<(9999)))
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK_StockQuantityLimit]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [CK_StockQuantityUnsigned] CHECK  (([StockQuantity]>=(0)))
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK_StockQuantityUnsigned]
GO
/****** Object:  StoredProcedure [dbo].[spOrder_Insert]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Karl Eludo
-- Create date: 15/1/2022
-- Description:	Used to insert an item in Order table
-- =============================================
CREATE PROCEDURE [dbo].[spOrder_Insert]
	@OrderId int = 0 output,
	@OrderDate datetime,
	@CustomerName nvarchar(50),
	@OrderTotalPrice float
	
	
	
AS
BEGIN
    -- Insert statements for procedure here
	insert into [dbo].[Order] (OrderDate, CustomerName, OrderTotalPrice)
	values (@OrderDate, @CustomerName, @OrderTotalPrice);

	select @OrderId = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spOrder_View]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Karl Eludo
-- Create date: 15/1/2022
-- Description:	Query an Order using OrderId as parameter
-- =============================================
CREATE PROCEDURE [dbo].[spOrder_View]
	@OrderId int,
	@CustomerName nvarchar(50) output,
	@OrderDate datetime output,
	@OrderTotalPrice float output
AS
BEGIN
	SELECT [Order].[CustomerName], [Order].[OrderDate], [Order].[OrderTotalPrice]
	FROM [Order]
	WHERE [OrderId] = @OrderId;
END
GO
/****** Object:  StoredProcedure [dbo].[spOrderLine_Insert]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 15/1/2022
-- Description:	Insert an OrderLine object into OrderLine table
--				Reduce stock quantity from dbo.Product
--				if the reduction parameter @Quantity is greater than
--				the dbo.Product stock quantity, set it to 0
-- 
-- =============================================
CREATE PROCEDURE [dbo].[spOrderLine_Insert]
	@OrderId int,
	@ProductId int,
	@Quantity int
	
	
	
AS
BEGIN
    -- Insert statements for procedure here
	insert into [dbo].[OrderLine] (OrderId, ProductId, Quantity)
	values (@OrderId, @ProductId, @Quantity);

	
	if ((select StockQuantity from Product where ProductId=@ProductId) > @Quantity)
	begin
		update [dbo].Product
			set StockQuantity = StockQuantity - @Quantity
			where ProductId=@ProductId;
	end
	else
	begin
		update [dbo].[Product]
			set 
				StockQuantity = 0, 
				inStock = 0
			where ProductId=@ProductId;
	end

END
GO
/****** Object:  StoredProcedure [dbo].[spOrderLine_View]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[spOrderLine_View]    Script Date: 16/01/2022 18:18:55 ******/

-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 15/1/2022
-- Description:	Get OrderLine items by OrderId
-- =============================================
CREATE PROCEDURE [dbo].[spOrderLine_View] 
	-- Add the parameters for the stored procedure here
	@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

    -- Insert statements for procedure here
	SELECT dbo.Product.Name, dbo.OrderLine.Quantity, dbo.Product.Price 
	from Product INNER JOIN OrderLine
	on Product.ProductId = OrderLine.ProductId
	where OrderLine.OrderId = @OrderId;
END
GO
/****** Object:  StoredProcedure [dbo].[spProduct_Delete]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 27/11/2021
-- Description:	Delete an Item from dbo.Product 
--				Using ProductId as parameter
-- =============================================
CREATE PROCEDURE [dbo].[spProduct_Delete]
	-- Add the parameters for the stored procedure here
	@ProductId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Product] where [dbo].[Product].[ProductId] = @ProductId
END
GO
/****** Object:  StoredProcedure [dbo].[spProduct_Insert]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 27/11/2022
-- Description:	Insert a product object to dbo.Product table
-- =============================================
CREATE PROCEDURE [dbo].[spProduct_Insert]
	@Name nvarchar(50),
	@Description nvarchar(max),
	@ImageByte varbinary(MAX),
	@CategoryId int,
	@StockQuantity smallint,
	@ProductId int = 0 output
	
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Product (Name, Description, ImageByte, CategoryId, StockQuantity)
	values (@Name, @Description, @ImageByte, @CategoryId, @StockQuantity);

	select @ProductId = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spProduct_ProductViewGetAll]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 27/11/2022
-- Description:	Select all items from dbo.Product table
-- =============================================
CREATE PROCEDURE [dbo].[spProduct_ProductViewGetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements
    -- Insert statements for procedure here
	SELECT [ProductId]
      ,[Name]
      ,[Description]
      ,[ImageByte]
      ,[CategoryId]
      ,[Price]
	FROM dbo.Product
END
GO
/****** Object:  StoredProcedure [dbo].[spProduct_Update]    Script Date: 26/01/2022 19:00:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Karl Glenn Eludo
-- Create date: 07/01/2022
-- Description:	Update an Item from dbo.Product table
-- =============================================
CREATE PROCEDURE [dbo].[spProduct_Update]
	@Name nvarchar(50)=NULL,
	@Description nvarchar(max)=NULL,
	@ImageByte varbinary(MAX)=NULL,
	@StockQuantity smallint=NULL,
	@Price float=NULL,
	@inStock bit=NULL,
	@CategoryId int=NULL,
	@ProductId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Product] 
		SET Name = ISNULL(@Name,Name), 
			Description =ISNULL(@Description,Description), 
			ImageByte =ISNULL(@ImageByte, ImageByte),
			StockQuantity =ISNULL(@StockQuantity,StockQuantity),
			Price =ISNULL(@Price,Price),
			inStock =ISNULL(@inStock, inStock)
		WHERE ProductId = @ProductId


END
GO

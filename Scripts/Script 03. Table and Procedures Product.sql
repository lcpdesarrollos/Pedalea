

GO
drop table if exists Product
create table Product
(
	Id int identity(1,1) not null,
	ProductName nvarchar(max) not null,
	Description nvarchar(max),
	Price decimal(18,6) default 0
)




GO
DROP PROCEDURE IF EXISTS spInsertProduct

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Luis Carlos Perez Fuentes>
-- Create date: <2023/01/02>
-- Description:	<Sp for insert products>
-- =============================================
CREATE PROCEDURE spInsertProduct
	@ProductName nvarchar(max) = null,
	@Description nvarchar(max) = null,
	@Price Decimal(18,6) = null
AS
BEGIN

	INSERT INTO Product
	(
		ProductName,
		Description,
		Price
	)
	VALUES
	(
		@ProductName,
		@Description,
		@Price
	)
	
END

GO
DROP PROCEDURE IF EXISTS spEditProduct

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Luis Carlos Perez Fuentes>
-- Create date: <2023/01/02>
-- Description:	<Sp for edit products>
-- =============================================
CREATE PROCEDURE spEditProduct
	@ProductName nvarchar(max) = null,
	@Description nvarchar(max) = null,
	@Price Decimal(18,6) = null,
	@Id int 
AS
BEGIN

	UPDATE Product SET
		ProductName = @ProductName,
		Description = @Description,
		Price = @Price
	WHERE Id = @Id
	
END


GO
DROP PROCEDURE IF EXISTS spDeleteProduct

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Luis Carlos Perez Fuentes>
-- Create date: <2023/01/02>
-- Description:	<Sp for delete products>
-- =============================================
CREATE PROCEDURE spDeleteProduct
	@Id int 
AS
BEGIN

	DELETE Product WHERE Id = @Id
	
END


GO
DROP PROCEDURE IF EXISTS spSelectProduct

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Luis Carlos Perez Fuentes>
-- Create date: <2023/01/02>
-- Description:	<Sp for delete products>
-- =============================================
CREATE PROCEDURE spSelectProduct
	
AS
BEGIN

	SELECT 
		Id,
		ProductName,
		Description,
		Price
	FROM Product 
	
END

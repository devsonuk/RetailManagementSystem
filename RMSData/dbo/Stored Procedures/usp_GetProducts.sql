CREATE PROCEDURE [dbo].[usp_GetProducts]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id]
		,[Name]
		,[Description]
		,[RetailPrice]
		,[QuantityInStock]
		,[IsTaxable]
	FROM [dbo].[Products]
	ORDER BY [Name]
END

RETURN 0

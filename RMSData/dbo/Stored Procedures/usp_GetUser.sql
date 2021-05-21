CREATE PROCEDURE [dbo].[usp_GetUser] @Id NVARCHAR(128)
AS
BEGIN
	SELECT Id
		,FirstName
		,LastName
		,EmailAddress
		,CreateDate
	FROM [dbo].[User]
	WHERE Id = @Id
END

CREATE PROCEDURE [dbo].[spUser_EmailSearch]
	@Email nvarchar(200)	
AS
BEGIN
	SELECT Id, FirstName, LastName, Email, Role From dbo.[User]
	WHERE Email = @Email
END
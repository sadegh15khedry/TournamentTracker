CREATE PROCEDURE [dbo].[spUser_GetByEmail]
	@Email nvarchar(200)	
AS
BEGIN
	SELECT Id, FirstName, LastName, Email, Role, Password From dbo.[User]
	WHERE Email = @Email
END

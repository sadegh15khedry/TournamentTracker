CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id int 
AS
Begin 
	SELECT Id, FirstName, LastName, Email From dbo.[User]
	WHERE Id = @Id
End
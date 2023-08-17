CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
Begin 
	SELECT Id, FirstName, LastName, Email From dbo.[User]
End
CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
Begin 
	SELECT Id, FirstName, LastName, Email, Role From dbo.[User]
End
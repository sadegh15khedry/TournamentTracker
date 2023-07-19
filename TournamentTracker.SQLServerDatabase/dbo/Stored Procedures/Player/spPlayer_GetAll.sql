CREATE PROCEDURE [dbo].[spPlayer_GetAll]
AS
Begin
	SELECT Id, SSN, FirstName, LastName, TeamId, Phone, Email
	From dbo.[Player]
End

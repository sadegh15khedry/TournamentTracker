CREATE PROCEDURE [dbo].[spPlayer_GetAll]
	@UserId int
AS
Begin
	SELECT Id, SSN, FirstName, LastName, TeamId, Phone, Email
	From dbo.[Player]
	Where UserId = @UserId
End

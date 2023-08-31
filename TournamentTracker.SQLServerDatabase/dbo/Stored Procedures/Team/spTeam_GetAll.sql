CREATE PROCEDURE [dbo].[spTeam_GetAll]
	@UserId int
As
Begin
	SELECT Id, Name, City, Owner From dbo.[Team]
	Where UserId = @UserId
End

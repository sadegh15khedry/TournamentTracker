CREATE PROCEDURE [dbo].[spPlayer_GetPlayerTeam]
	@TeamId int,
	@UserId int
AS
Begin
	Select Id, Name, City, Owner From dbo.[Team]
	Where Id = @TeamId and UserId = @UserId
End

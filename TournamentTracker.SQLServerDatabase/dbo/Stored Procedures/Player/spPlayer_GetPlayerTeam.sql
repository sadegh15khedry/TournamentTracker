CREATE PROCEDURE [dbo].[spPlayer_GetPlayerTeam]
	@TeamId int
AS
Begin
	Select Id, Name, City, Owner From dbo.[Team]
	Where Id = @TeamId
End

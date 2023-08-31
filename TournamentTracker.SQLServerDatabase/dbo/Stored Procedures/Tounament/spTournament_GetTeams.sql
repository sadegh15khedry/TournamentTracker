CREATE PROCEDURE [dbo].[spTournament_GetTeams]
	@TournamentId int,
	@UserId int
AS
Begin
	SELECT Id, Name, City, Owner From dbo.[Team]
	Where  UserId = @UserId and Id in ( Select TeamId from dbo.[TournamentTeam]
					Where TournamentId = @TournamentId  and UserId = @UserId)

End

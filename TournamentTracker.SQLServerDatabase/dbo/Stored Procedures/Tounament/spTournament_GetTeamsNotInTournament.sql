CREATE PROCEDURE [dbo].[spTournament_GetTeamsNotInTournament]
	@TournamentId int,
	@UserId int
AS
Begin
	Select Id, Name, City, Owner From dbo.[Team]
	  Where  UserId = @UserId and Id Not In (Select TeamId From dbo.[TournamentTeam]
						Where TournamentId = @TournamentId and UserId = @UserId)
End

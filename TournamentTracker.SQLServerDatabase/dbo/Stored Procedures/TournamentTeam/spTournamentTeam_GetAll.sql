CREATE PROCEDURE [dbo].[spTournamentTeam_GetAll]
	@UserId int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam]
	Where  UserId = @UserId
End

CREATE PROCEDURE [dbo].[spTournamentTeam_GetByTeamId]
	@TeamId int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam]
	Where @TeamId = @TeamId
End

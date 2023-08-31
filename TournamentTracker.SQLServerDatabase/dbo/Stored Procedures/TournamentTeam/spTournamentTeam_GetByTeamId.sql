CREATE PROCEDURE [dbo].[spTournamentTeam_GetByTeamId]
	@TeamId int,
	@UserId int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam]
	Where @TeamId = @TeamId and UserId = @UserId
End

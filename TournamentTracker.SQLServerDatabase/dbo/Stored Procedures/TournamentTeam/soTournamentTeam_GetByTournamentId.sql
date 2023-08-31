CREATE PROCEDURE [dbo].[soTournamentTeam_GetByTournamentId]
	@TournamentId int,
	@UserId int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam]
	Where TournamentId = @TournamentId and UserId = @UserId
End

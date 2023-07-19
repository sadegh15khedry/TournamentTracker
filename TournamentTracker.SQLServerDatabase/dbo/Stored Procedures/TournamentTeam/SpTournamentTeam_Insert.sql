CREATE PROCEDURE [dbo].[SpTournamentTeam_Insert]
	@TeamId int,
	@TournamentId int
AS
Begin
	Insert Into dbo.[TournamentTeam] (TeamId, TournamentId)
	Values (@TeamId, @TournamentId)
End

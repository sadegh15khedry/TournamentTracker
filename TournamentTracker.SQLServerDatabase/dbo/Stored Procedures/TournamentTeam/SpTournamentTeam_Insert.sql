CREATE PROCEDURE [dbo].[SpTournamentTeam_Insert]
	@TeamId int,
	@TournamentId int
AS
Begin
	Insert Into dbo.[TournamentTeam]
		(TeamId, TournamentId)
	output
	Inserted.Id,
	Inserted.TournamentId,
	Inserted.TeamId
	Values
		(@TeamId, @TournamentId)
End

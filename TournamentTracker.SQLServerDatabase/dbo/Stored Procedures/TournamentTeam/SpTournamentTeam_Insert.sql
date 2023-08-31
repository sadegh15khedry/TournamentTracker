CREATE PROCEDURE [dbo].[SpTournamentTeam_Insert]
	@TeamId int,
	@TournamentId int,
	@UserId int
AS
Begin
	Insert Into dbo.[TournamentTeam]
		(TeamId, TournamentId, UserId)
	output
	Inserted.Id,
	Inserted.TournamentId,
	Inserted.TeamId
	Values
		(@TeamId, @TournamentId, @UserId)
End

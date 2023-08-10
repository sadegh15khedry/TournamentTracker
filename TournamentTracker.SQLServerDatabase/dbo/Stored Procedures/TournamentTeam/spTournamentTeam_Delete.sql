CREATE PROCEDURE [dbo].[spTournamentTeam_Delete]
	@TeamId int,
	@TournamentId int
AS
Begin
	Delete from dbo.[TournamentTeam] 
	output Deleted.Id, Deleted.TournamentId, Deleted.TeamId
	Where TeamId = @TeamId And TournamentId = @TournamentId
End

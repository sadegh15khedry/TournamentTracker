CREATE PROCEDURE [dbo].[spTournamentTeam_Delete]
	@TeamId int,
	@TournamentId int
AS
Begin
	Delete from dbo.[TournamentTeam] 
	Where TeamId = @TeamId And TournamentId = @TournamentId
End

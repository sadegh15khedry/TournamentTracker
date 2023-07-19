CREATE PROCEDURE [dbo].[soTournamentTeam_GetByTournamentId]
	@TournamentId int
AS
Begin
	Select * from dbo.[TournamentTeam]
	Where TournamentId = @TournamentId
End

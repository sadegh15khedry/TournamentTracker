CREATE PROCEDURE [dbo].[spSeries_GetByTournamentId]
	@TournamentId int
AS
Begin
	SELECT Id, Round, PlaceInRound, IsSeriesFinished, FirstTeamId, SecondTeamId, TournamentId
	From dbo.[Series] 
	Where TournamentId = @TournamentId
End

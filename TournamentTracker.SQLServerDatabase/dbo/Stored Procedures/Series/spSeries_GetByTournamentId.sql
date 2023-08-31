CREATE PROCEDURE [dbo].[spSeries_GetByTournamentId]
	@TournamentId int,
	@UserId int
AS
Begin
	SELECT Id, Round, PlaceInRound, isSeriesEnded, FirstTeamId, SecondTeamId, TournamentId
	From dbo.[Series] 
	Where TournamentId = @TournamentId and UserId = @UserId
End

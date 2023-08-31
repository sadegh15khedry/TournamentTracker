CREATE PROCEDURE [dbo].[spSeries_GetAll]
	@UserId int
AS
Begin
	SELECT Id, Round, PlaceInRound, isSeriesEnded, FirstTeamId, SecondTeamId, TournamentId
	From dbo.[Series]
	Where UserId = @UserId
End

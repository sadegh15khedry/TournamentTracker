CREATE PROCEDURE [dbo].[spSeries_GetAll]
AS
Begin
	SELECT Id, Round, PlaceInRound, isSeriesEnded, FirstTeamId, SecondTeamId, TournamentId
	From dbo.[Series]
End

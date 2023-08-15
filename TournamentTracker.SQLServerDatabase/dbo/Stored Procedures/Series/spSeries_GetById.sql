CREATE PROCEDURE [dbo].[spSeries_GetById]
	@Id int
AS
Begin
	SELECT Id, Round, PlaceInRound, isSeriesEnded, FirstTeamId, SecondTeamId, TournamentId
	From dbo.[Series]
	where Id = @Id
End
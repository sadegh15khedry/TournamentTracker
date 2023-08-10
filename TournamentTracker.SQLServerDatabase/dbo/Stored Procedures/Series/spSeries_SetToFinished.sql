CREATE PROCEDURE [dbo].[spSeries_SetToFinished]
	@Id int
AS
Begin
	Update dbo.[Series] Set IsSeriesFinished = 1
	output
	Inserted.Id,
	Inserted.Round,
	Inserted.PlaceInRound,
	Inserted.IsSeriesFinished,
	Inserted.FirstTeamId,
	Inserted.SecondTeamId,
	Inserted.TournamentId
	Where Id = @Id
End


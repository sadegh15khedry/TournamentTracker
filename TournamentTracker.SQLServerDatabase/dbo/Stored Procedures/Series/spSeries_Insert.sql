CREATE PROCEDURE [dbo].[spSeries_Insert]
	@Round int,
	@PlaceInRound int,
	@FirstTeamId int,
	@SecondTeamId int,
	@TournamentId int
AS
Begin
	Insert Into dbo.[Series]
		(Round, PlaceInRound, IsSeriesFinished, FirstTeamId, SecondTeamId, TournamentId)
	output
	Inserted.Id,
	Inserted.Round,
	Inserted.PlaceInRound,
	Inserted.IsSeriesFinished,
	Inserted.FirstTeamId,
	Inserted.SecondTeamId,
	Inserted.TournamentId
	Values
		(@Round, @PlaceInRound, 0, @FirstTeamId, @SecondTeamId, @TournamentId)
End
CREATE PROCEDURE [dbo].[spSeries_Insert]
	@Round int, 
	@PlaceInRound int,
	@FirstTeamId int,
	@SecondTeamId int,
	@TournamentId int
AS
Begin
	Insert Into dbo.[Series] (Round, PlaceInRound, IsSeriesFinished, FirstTeamId, SecondTeamId, TournamentId)
	Values (@Round, @PlaceInRound, 0, @FirstTeamId, @SecondTeamId, @TournamentId)
End
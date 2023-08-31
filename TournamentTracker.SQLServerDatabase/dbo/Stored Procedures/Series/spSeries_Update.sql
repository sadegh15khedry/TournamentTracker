CREATE PROCEDURE [dbo].[spSeries_Update]
	@Id int,
	@Round int,
	@IsSeriesFinished bit,
	@PlaceInRound int,
	@FirstTeamId int,
	@SecondTeamId int,
	@TournamentId int,
	@UserId int
AS
Begin
	Update dbo.[Series] 
	Set Round = @Round, isSeriesEnded = @IsSeriesFinished, PlaceInRound = @PlaceInRound,  
		@FirstTeamId = @FirstTeamId, SecondTeamId = @SecondTeamId, TournamentId = @TournamentId
	output
	Inserted.Id,
	Inserted.Round,
	Inserted.PlaceInRound,
	Inserted.IsSeriesEnded,
	Inserted.FirstTeamId,
	Inserted.SecondTeamId,
	Inserted.TournamentId
	Where Id = @Id and UserId = @UserId
End
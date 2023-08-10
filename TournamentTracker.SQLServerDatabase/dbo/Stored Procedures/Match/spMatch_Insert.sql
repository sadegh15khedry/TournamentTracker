CREATE PROCEDURE [dbo].[spMatch_Insert]
	@Outcome int,
	@FirstTeamScore int,
	@SecondTeamScore int,
	@SeriesId int
AS
Begin
	Insert Into dbo.[Match]
		(Outcome, FirstTeamScore, SecondTeamScore, SeriesId)
	OUTPUT
	Inserted.Id,
	Inserted.Outcome,
	Inserted.FirstTeamScore,
	Inserted.SecondTeamScore
	Values
		(@Outcome, @FirstTeamScore, @SecondTeamScore, @SeriesId)
End

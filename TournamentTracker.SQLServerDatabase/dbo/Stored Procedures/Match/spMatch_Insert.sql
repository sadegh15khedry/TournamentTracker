CREATE PROCEDURE [dbo].[spMatch_Insert]
	@Outcome int,
	@FirstTeamScore int,
	@SecondTeamScore int,
	@SeriesId int,
	@UserId int
AS
Begin
	Insert Into dbo.[Match]
		(Outcome, FirstTeamScore, SecondTeamScore, SeriesId, UserId)
	OUTPUT
	Inserted.Id,
	Inserted.Outcome,
	Inserted.FirstTeamScore,
	Inserted.SecondTeamScore,
	inserted.UserId
	Values
		(@Outcome, @FirstTeamScore, @SecondTeamScore, @SeriesId, @UserId)
End

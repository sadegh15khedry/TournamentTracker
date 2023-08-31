CREATE PROCEDURE [dbo].[spMatch_Update]
	@Id int = 0,
	@Outcome int,
	@FirstTeamScore int,
	@SecondTeamScore int,
	@SeriesId int,
	@UserId int
As
Begin
	Update dbo.[Match] 

	Set Outcome = @Outcome, FirstTeamScore = @FirstTeamScore,
	SecondTeamScore = @SecondTeamScore, SeriesId = @SeriesId
	Output Inserted.Outcome , Inserted.FirstTeamScore ,
	Inserted.SecondTeamScore, Inserted.SeriesId , inserted.UserId
	where Id = @Id and UserId = @UserId
End

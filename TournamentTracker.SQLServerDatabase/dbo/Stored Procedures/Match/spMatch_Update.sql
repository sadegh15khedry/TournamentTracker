CREATE PROCEDURE [dbo].[spMatch_Update]
	@Id int = 0,
	@Outcome int,
	@FirstTeamScore int,
	@SecondTeamScore int,
	@SeriesId int
As
Begin
	Update dbo.[Match] 

	Set Outcome = @Outcome, FirstTeamScore = @FirstTeamScore,
	SecondTeamScore = @SecondTeamScore, SeriesId = @SeriesId
	Output Inserted.Outcome , Inserted.FirstTeamScore ,
	Inserted.SecondTeamScore, Inserted.SeriesId 
	where Id = @Id
End

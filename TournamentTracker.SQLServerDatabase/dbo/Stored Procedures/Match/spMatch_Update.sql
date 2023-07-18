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
End

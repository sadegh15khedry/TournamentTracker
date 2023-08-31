CREATE PROCEDURE [dbo].[spMatch_GetBySeriesId]
	@SeriesId int, 
	@UserId int
AS
Begin
	SELECT Id, Outcome, FirstTeamScore,  SecondTeamScore, SeriesId
	From dbo.[Match] 
	Where SeriesId = @SeriesId and UserId = @UserId
End
CREATE PROCEDURE [dbo].[spMatch_GetBySeriesId]
	@SeriesId int
AS
Begin
	SELECT Id, Outcome, FirstTeamScore,  SecondTeamScore, SeriesId
	From dbo.[Match] 
	Where SeriesId = @SeriesId
End
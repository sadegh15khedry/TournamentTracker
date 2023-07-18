CREATE PROCEDURE [dbo].[spMatch_GetAll]
AS
begin
		SELECT Id, Outcome, FirstTeamScore, SecondTeamScore, SeriesId
		From dbo.[Match]
end
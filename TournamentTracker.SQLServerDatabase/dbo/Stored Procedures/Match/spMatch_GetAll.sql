CREATE PROCEDURE [dbo].[spMatch_GetAll]
	@UserId int
AS
begin
		SELECT Id, Outcome, FirstTeamScore, SecondTeamScore, SeriesId
		From dbo.[Match]
		Where UserId = @UserId
end
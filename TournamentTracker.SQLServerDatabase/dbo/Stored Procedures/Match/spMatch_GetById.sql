CREATE PROCEDURE [dbo].[spMatch_GetById]
 @Id int,
 @UserId int
As
begin
		SELECT Id, Outcome, FirstTeamScore, SecondTeamScore, SeriesId
		From dbo.[Match]
		Where Id = @Id and UserId = @UserId
end

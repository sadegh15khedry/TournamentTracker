CREATE PROCEDURE [dbo].[spMatch_Delete]
	@Id int,
	@UserId int
AS
Begin
	Delete From dbo.[Match] 
	Output Deleted.Id, Deleted.FirstTeamScore, Deleted.FirstTeamScore, Deleted.SeriesId, Deleted.UserId
	Where Id = @Id and UserId = @UserId
End
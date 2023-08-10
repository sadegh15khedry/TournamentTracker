CREATE PROCEDURE [dbo].[spMatch_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Match] 
	Output Deleted.Id, Deleted.FirstTeamScore, Deleted.FirstTeamScore, Deleted.SeriesId
	Where Id = @Id
End
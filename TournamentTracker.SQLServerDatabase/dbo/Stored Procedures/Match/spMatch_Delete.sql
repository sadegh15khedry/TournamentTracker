CREATE PROCEDURE [dbo].[spMatch_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Match] 
	Output Deleted.Id, Deleted.FirstTeamId, Deleted.SecondTeamId, Deleted.SeriesId
	Where Id = @Id
End
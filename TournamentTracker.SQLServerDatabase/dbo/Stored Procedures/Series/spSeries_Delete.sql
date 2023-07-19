CREATE PROCEDURE [dbo].[spSeries_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Series]
	Where Id = @Id
End
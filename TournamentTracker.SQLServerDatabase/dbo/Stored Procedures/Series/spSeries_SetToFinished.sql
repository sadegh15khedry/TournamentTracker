CREATE PROCEDURE [dbo].[spSeries_SetToFinished]
	@Id int
AS
Begin
	Update dbo.[Series] Set IsSeriesFinished = 1
	Where Id = @Id
End


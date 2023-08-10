CREATE PROCEDURE [dbo].[spSeries_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Series]
	output Deleted.Id, Deleted.Round, Deleted.PlaceInRound, Deleted.IsSeriesFinished,
	Deleted.FirstTeamId, Deleted.SecondTeamId, Deleted.TournamentId
	Where Id = @Id
End
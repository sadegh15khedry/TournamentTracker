CREATE PROCEDURE [dbo].[spSeries_Delete]
	@Id int,
	@UserId int
AS
Begin
	Delete From dbo.[Series]
	output Deleted.Id, Deleted.Round, Deleted.PlaceInRound, Deleted.isSeriesEnded,
	Deleted.FirstTeamId, Deleted.SecondTeamId, Deleted.TournamentId
	Where Id = @Id and UserId = @UserId
End
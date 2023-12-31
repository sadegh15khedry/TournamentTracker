﻿CREATE PROCEDURE [dbo].[spSeries_SetToFinished]
	@SeriesId  int,
	@UserId int
AS
Begin
	Update dbo.[Series] Set isSeriesEnded = 1
	output Inserted.Id,
	Inserted.Round,
	Inserted.PlaceInRound,
	Inserted.isSeriesEnded,
	Inserted.FirstTeamId,
	Inserted.SecondTeamId,
	Inserted.TournamentId

	where Id = @SeriesId and UserId = @UserId
End
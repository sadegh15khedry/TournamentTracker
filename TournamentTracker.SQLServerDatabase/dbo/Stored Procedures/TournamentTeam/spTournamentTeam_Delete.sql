CREATE PROCEDURE [dbo].[spTournamentTeam_Delete]
	@TeamId int,
	@TournamentId int,
	@UserId int
AS
Begin
	Delete from dbo.[TournamentTeam] 
	output Deleted.Id, Deleted.TournamentId, Deleted.TeamId
	Where TeamId = @TeamId And TournamentId = @TournamentId and UserId = @UserId
End

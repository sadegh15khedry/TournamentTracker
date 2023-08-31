CREATE PROCEDURE [dbo].[spTournamentTeam_GetById]
	@Id int,
	@UserId int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam] 
	Where Id = @Id and UserId = @UserId
End

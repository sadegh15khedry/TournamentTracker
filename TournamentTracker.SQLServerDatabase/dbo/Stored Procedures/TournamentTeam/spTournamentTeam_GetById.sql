CREATE PROCEDURE [dbo].[spTournamentTeam_GetById]
	@Id int
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam] 
	Where Id = @Id
End

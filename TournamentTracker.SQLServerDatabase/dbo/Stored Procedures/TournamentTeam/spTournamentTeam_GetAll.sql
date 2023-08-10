CREATE PROCEDURE [dbo].[spTournamentTeam_GetAll]
AS
Begin
	Select Id, TournamentId, TeamId from dbo.[TournamentTeam]
End

CREATE PROCEDURE [dbo].[spTournament_GetTeams]
	@TournamentId int
AS
Begin
	SELECT Id, Name, City, Owner From dbo.[Team]
	Where Id in ( Select TeamId from dbo.[TournamentTeam]
					Where TournamentId = @TournamentId )

End

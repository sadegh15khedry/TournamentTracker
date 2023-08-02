CREATE PROCEDURE [dbo].[spTournament_GetTeamsNotInTournament]
	@TournamentId int
AS
Begin
	Select Id, Name, City, Owner From dbo.[Team]
	Where Id Not In (Select TeamId From dbo.[TournamentTeam]
						Where TournamentId = @TournamentId )
End

CREATE PROCEDURE [dbo].[spTournamentTeam_GetByTeamId]
	@TeamId int
AS
Begin
	Select * from dbo.[TournamentTeam]
	Where @TeamId = @TeamId
End

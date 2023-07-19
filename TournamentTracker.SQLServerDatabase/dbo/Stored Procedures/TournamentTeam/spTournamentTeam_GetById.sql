CREATE PROCEDURE [dbo].[spTournamentTeam_GetById]
	@Id int
AS
Begin
	Select * from dbo.[TournamentTeam] 
	Where Id = @Id
End

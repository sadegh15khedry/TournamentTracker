CREATE PROCEDURE [dbo].[spTournamentTeam_Delete]
	@Id int
AS
Begin
	Delete from dbo.[TournamentTeam] 
	Where Id = @Id
End

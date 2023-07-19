CREATE PROCEDURE [dbo].[spTournament_SetToFinished]
	@Id int
AS
Begin
	Update dbo.[Tournament] Set IsFinished = 1
	Where Id = @Id
End
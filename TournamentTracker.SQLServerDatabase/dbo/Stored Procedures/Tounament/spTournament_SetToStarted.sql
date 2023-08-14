CREATE PROCEDURE [dbo].[spTournament_SetToStarted]
	@Id int
AS
Begin
	Update dbo.[Tournament] Set IsStarted = 1
	output Inserted.Id, Inserted.Name, Inserted.Location,
	Inserted.Description, Inserted.IsFinished, Inserted.IsStarted
	Where Id = @Id
End
﻿CREATE PROCEDURE [dbo].[spTournament_SetToFinished]
	@Id int
AS
Begin
	Update dbo.[Tournament] Set IsFinished = 1
	output Inserted.Id, Inserted.Name, Inserted.Location,
	Inserted.Description, Inserted.IsFinished, Inserted.IsStarted
	Where Id = @Id
End
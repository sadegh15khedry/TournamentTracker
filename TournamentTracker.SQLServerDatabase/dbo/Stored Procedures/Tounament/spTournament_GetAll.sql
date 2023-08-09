CREATE PROCEDURE [dbo].[spTournament_GetAll]
AS
Begin
	SELECT Id, Name, Location,Description, IsFinished, IsStarted
	From dbo.[Tournament]
End
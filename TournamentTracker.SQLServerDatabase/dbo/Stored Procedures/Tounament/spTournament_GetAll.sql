CREATE PROCEDURE [dbo].[spTournament_GetAll]
AS
Begin
	SELECT Id, Name, Location,Description, IsFinished 
	From dbo.[Tournament]
End
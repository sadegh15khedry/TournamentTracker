CREATE PROCEDURE [dbo].[spTournament_GetById]
	@Id int
AS
Begin
	SELECT Id, Name, Location,Description, IsStarted, IsFinished
	From dbo.[Tournament]
	where Id=@Id
End
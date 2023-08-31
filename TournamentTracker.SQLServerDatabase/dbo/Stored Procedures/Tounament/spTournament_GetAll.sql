CREATE PROCEDURE [dbo].[spTournament_GetAll]
	@UserId int
AS
Begin
	SELECT Id, Name, Location,Description, IsFinished, IsStarted
	From dbo.[Tournament]
	Where UserId = @UserId
End
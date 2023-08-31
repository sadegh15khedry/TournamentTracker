CREATE PROCEDURE [dbo].[spTournament_GetById]
	@Id int,
	@UserId int
AS
Begin
	SELECT Id, Name, Location,Description, IsStarted, IsFinished
	From dbo.[Tournament]
	where Id=@Id and UserId = @UserId
End
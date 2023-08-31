CREATE PROCEDURE [dbo].[spTournament_Delete]
	@Id int,
	@UserId int
AS
Begin
	Delete From dbo.[Tournament]
	output Deleted.Id, Deleted.Name, Deleted.Location, Deleted.Description, 
	Deleted.IsFinished, Deleted.IsStarted
	where Id = @Id and UserId = @UserId
End

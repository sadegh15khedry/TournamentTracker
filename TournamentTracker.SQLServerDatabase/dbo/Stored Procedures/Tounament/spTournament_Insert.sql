CREATE PROCEDURE [dbo].[spTournament_Insert]
	@Name nvarchar(100),
	@Location nvarchar(100),
	@Description nvarchar(100),
	@UserId int
AS
Begin
	Insert Into dbo.[Tournament] (Name, Description, Location,  IsFinished, IsStarted,UserId)
	output Inserted.Id, Inserted.Name, Inserted.Location,
	Inserted.Description, Inserted.IsFinished, Inserted.IsStarted
	
	Values (@Name, @Description, @Location, 0, 0, @UserId)
	
End

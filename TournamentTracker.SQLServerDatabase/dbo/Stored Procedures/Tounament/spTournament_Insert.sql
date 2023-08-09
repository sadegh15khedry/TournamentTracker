CREATE PROCEDURE [dbo].[spTournament_Insert]
	@Name nvarchar(100),
	@Location nvarchar(100),
	@Description nvarchar(100)
AS
Begin
	Insert Into dbo.[Tournament] (Name, Description, Location,  IsFinished, IsStarted)
	Values (@Name, @Description, @Location, 0, 0 )
	
End

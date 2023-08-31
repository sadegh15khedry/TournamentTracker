CREATE PROCEDURE [dbo].[spTournament_Update]
	@Id int ,
	@Name nvarchar(100),
	@Location nvarchar(100),
	@Description nvarchar(100),
	@IsFinished bit,
	@IsStarted bit,
	@UserId int
AS
Begin
	Update dbo.[Tournament]
	Set Name = @Name,
	Description = @Description,
	Location = @Location,
	IsFinished = @IsFinished,
	IsStarted = @IsStarted
	output Inserted.Id, Inserted.Name, Inserted.Location,
	Inserted.Description, Inserted.IsFinished, Inserted.IsStarted

	Where Id = @Id and UserId = @UserId
End

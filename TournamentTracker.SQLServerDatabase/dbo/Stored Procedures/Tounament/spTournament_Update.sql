CREATE PROCEDURE [dbo].[spTournament_Update]
	@Id int ,
	@Name nvarchar(100),
	@Location nvarchar(100),
	@Description nvarchar(100),
	@IsFinished bit
AS
Begin
	Update dbo.[Tournament]
	Set Name = @Name,
	Description = @Description,
	Location = @Location,
	IsFinished = @IsFinished
	Where Id = @Id
End

CREATE PROCEDURE [dbo].[spTournament_Delete]
	@Id int 
AS
Begin
	Delete From dbo.[Tournament]
	where Id = @Id
End

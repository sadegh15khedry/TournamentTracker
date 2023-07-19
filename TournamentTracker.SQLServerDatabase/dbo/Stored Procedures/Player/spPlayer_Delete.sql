CREATE PROCEDURE [dbo].[spPlayer_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Player]
	Where Id = @Id
End

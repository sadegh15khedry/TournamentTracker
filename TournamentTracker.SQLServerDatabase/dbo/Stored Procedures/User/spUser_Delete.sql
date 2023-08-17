CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
Begin
	Delete From dbo.[User]
	where Id = @Id
End
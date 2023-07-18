CREATE PROCEDURE [dbo].[spMatch_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Match] 
	Where Id = @Id
End
CREATE PROCEDURE [dbo].[spTeam_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Team]
	Where Id = @Id
End
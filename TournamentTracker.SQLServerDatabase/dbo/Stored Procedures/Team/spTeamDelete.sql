CREATE PROCEDURE [dbo].[spTeamDelete]
	@Id int
AS
Begin
	Delete From dbo.[Team]
	Where Id = @Id
End
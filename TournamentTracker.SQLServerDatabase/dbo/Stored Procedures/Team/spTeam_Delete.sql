CREATE PROCEDURE [dbo].[spTeam_Delete]
	@Id int,
	@UserId int
AS
Begin
	Delete From dbo.[Team]
	output Deleted.Id, Deleted.Name, Deleted.City, Deleted.Owner
	Where Id = @Id and UserId = @UserId
End
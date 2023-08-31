CREATE PROCEDURE [dbo].[spTeam_GetById]
	@Id int,
	@UserId int
AS
Begin
	SELECT Id, Name, City, Owner From dbo.[Team]
	Where Id = @Id and UserId = @UserId
End
CREATE PROCEDURE [dbo].[spTeam_Insert]
	@Name nvarchar (500),
	@City nvarchar (500),
	@Owner nvarchar (500),
	@UserId int
AS
Begin 
	Insert Into dbo.[Team] (Name, City, Owner, UserId)
	output INSERTED.Id, Inserted.Name, Inserted.City, Inserted.Owner
	Values (@Name, @City, @Owner, @UserId)
End
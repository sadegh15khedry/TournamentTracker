CREATE PROCEDURE [dbo].[spTeam_Insert]
	@Name nvarchar (500),
	@City nvarchar (500),
	@Owner nvarchar (500)
AS
Begin 
	Insert Into dbo.[Team] (Name, City, Owner)
	Values (@Name, @City, @Owner)
End
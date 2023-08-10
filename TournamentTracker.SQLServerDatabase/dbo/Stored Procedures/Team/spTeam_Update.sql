CREATE PROCEDURE [dbo].[spTeam_Update]
	@Id int,
	@Name nvarchar (500),
	@City nvarchar (500),
	@Owner nvarchar (500)
AS
Begin
	Update dbo.[Team] Set Name = @Name, City = @City, Owner = @Owner
	output Inserted.Id, Inserted.Name, Inserted.City, Inserted.Owner
	Where Id = @Id
End

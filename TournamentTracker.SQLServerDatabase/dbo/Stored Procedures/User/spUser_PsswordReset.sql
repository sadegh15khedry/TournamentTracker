CREATE PROCEDURE [dbo].[spUser_PsswordReset]
	@Id int, 
	@Password nvarchar(800)
AS
BEGIN
	Update dbo.[User] Set Password = @Password
	OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role
	Where Id = @Id
END
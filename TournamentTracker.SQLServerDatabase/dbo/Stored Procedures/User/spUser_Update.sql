CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int, 
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(2000)
AS
BEGIN
	Update dbo.[User] Set FirstName = @FirstName, LastName = @LastName, Email = @Email
	OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role
	Where Id = @Id
END

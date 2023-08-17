CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(2000),
	@Password nvarchar(800)
AS
BEGIN
	INSERT INTO dbo.[User] (FirstName, LastName, Email, Password)
	OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email
	VALUES (@FirstName, @LastName, @Email, @Password)
END

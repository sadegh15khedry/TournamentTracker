CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(2000),
	@Password nvarchar(800)
AS
BEGIN
	INSERT INTO dbo.[User] (FirstName, LastName, Email, Password, Role)
		OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role,
	Inserted.EmailVerificationCode,Inserted.EmailVerificationCondeExpirationDate,
    Inserted.IsEmailVerified,Inserted.PhoneNumber,Inserted.IsPhoneNumberVerified, 
    Inserted.PhoneVerificationConde,Inserted.PhoneVerificationCondeExpirationDate
	VALUES (@FirstName, @LastName, @Email, @Password, 'User')
END

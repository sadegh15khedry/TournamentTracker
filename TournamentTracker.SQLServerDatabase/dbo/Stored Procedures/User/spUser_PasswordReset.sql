CREATE PROCEDURE [dbo].[spUser_PasswordReset]
	@Id int, 
	@Password nvarchar(800)
AS
BEGIN
	Update dbo.[User] Set Password = @Password
		OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role,
	Inserted.EmailVerificationCode,Inserted.EmailVerificationCodeExpirationDate,
    Inserted.IsEmailVerified,Inserted.PhoneNumber,Inserted.IsPhoneNumberVerified, 
    Inserted.PhoneVerificationCode , Inserted.PhoneVerificationCodeExpirationDate
	Where Id = @Id
END
CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id int 
AS
Begin 
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode,EmailVerificationCondeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationConde,PhoneVerificationCondeExpirationDate
	From dbo.[User]
	WHERE Id = @Id
End
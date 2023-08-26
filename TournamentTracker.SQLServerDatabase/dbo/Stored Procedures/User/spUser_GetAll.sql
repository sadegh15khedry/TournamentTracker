CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
Begin 
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode, EmailVerificationCodeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationCode,PhoneVerificationCodeExpirationDate From dbo.[User]
End
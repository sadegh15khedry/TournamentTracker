CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
Begin 
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode,EmailVerificationCondeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationConde,PhoneVerificationCondeExpirationDate From dbo.[User]
End
CREATE PROCEDURE [dbo].[spUser_GetByEmail]
	@Email nvarchar(200)	
AS
BEGIN
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode,EmailVerificationCodeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationCode,PhoneVerificationCodeExpirationDate
	From dbo.[User]
	WHERE Email = @Email
END

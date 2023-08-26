CREATE PROCEDURE [dbo].[spUser_GetByEmail]
	@Email nvarchar(200)	
AS
BEGIN
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode,EmailVerificationCondeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationConde,PhoneVerificationCondeExpirationDate
	From dbo.[User]
	WHERE Email = @Email
END

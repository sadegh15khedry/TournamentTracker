﻿CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id int 
AS
Begin 
	SELECT Id, FirstName, LastName, Email, Role,Password ,
	EmailVerificationCode,EmailVerificationCodeExpirationDate,
    IsEmailVerified,PhoneNumber,IsPhoneNumberVerified, 
    PhoneVerificationCode,PhoneVerificationCodeExpirationDate
	From dbo.[User]
	WHERE Id = @Id
End
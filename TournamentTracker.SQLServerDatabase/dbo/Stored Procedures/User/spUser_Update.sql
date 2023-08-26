CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int, 
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(2000),
	
	@EmailVerificationCode nvarchar(200),
	@EmailVerificationCodeExpirationDate DateTime2,
    @IsEmailVerified bit,
    @PhoneNumber nvarchar(50),
    @IsPhoneNumberVerified bit, 
    @PhoneVerificationCode nvarchar(200),
    @PhoneVerificationCodeExpirationDate DateTime2

AS
BEGIN
	Update dbo.[User] Set FirstName = @FirstName, LastName = @LastName, Email = @Email,
	EmailVerificationCode =  @EmailVerificationCode,
    EmailVerificationCodeExpirationDate = @EmailVerificationCodeExpirationDate,
    IsEmailVerified = @IsEmailVerified, PhoneNumber = @PhoneNumber,
    IsPhoneNumberVerified = @IsPhoneNumberVerified, PhoneVerificationCode = @PhoneVerificationCode,
    PhoneVerificationCodeExpirationDate = @PhoneVerificationCodeExpirationDate


	OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role,
	Inserted.EmailVerificationCode,Inserted.EmailVerificationCodeExpirationDate,
    Inserted.IsEmailVerified,Inserted.PhoneNumber,Inserted.IsPhoneNumberVerified, 
    Inserted.PhoneVerificationCode,Inserted.PhoneVerificationCodeExpirationDate
	Where Id = @Id
END

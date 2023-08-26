CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int, 
	@FirstName nvarchar(200),
	@LastName nvarchar(200),
	@Email nvarchar(2000),
	
	@EmailVerificationConde nvarchar(200),
	@EmailVerificationCondeExpirationDate DateTime2,
    @IsEmailVerified bit,
    @PhoneNumber nvarchar(50),
    @IsPhoneNumberVerified bit, 
    @PhoneVerificationConde nvarchar(200),
    @PhoneVerificationCondeExpirationDate DateTime2

AS
BEGIN
	Update dbo.[User] Set FirstName = @FirstName, LastName = @LastName, Email = @Email,
	EmailVerificationCode =  @EmailVerificationConde,
    EmailVerificationCondeExpirationDate = @EmailVerificationCondeExpirationDate,
    IsEmailVerified = @IsEmailVerified, PhoneNumber = @PhoneNumber,
    IsPhoneNumberVerified = @IsPhoneNumberVerified, PhoneVerificationConde = @PhoneVerificationConde,
    PhoneVerificationCondeExpirationDate = @PhoneVerificationCondeExpirationDate


	OUTPUT INSERTED.Id, inserted.FirstName, INSERTED.LastName, inserted.Email, inserted.Role,
	Inserted.EmailVerificationCode,Inserted.EmailVerificationCondeExpirationDate,
    Inserted.IsEmailVerified,Inserted.PhoneNumber,Inserted.IsPhoneNumberVerified, 
    Inserted.PhoneVerificationConde,Inserted.PhoneVerificationCondeExpirationDate
	Where Id = @Id
END

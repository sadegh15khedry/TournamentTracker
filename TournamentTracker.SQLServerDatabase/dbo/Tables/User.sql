CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(2000) NOT NULL, 
    [Password] NVARCHAR(800) NOT NULL, 
    [FirstName] NVARCHAR(200) NOT NULL, 
    [LastName] NVARCHAR(200) NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL, 
    [EmailVerificationCode] NVARCHAR(200) NULL, 
    [EmailVerificationCodeExpirationDate] DATETIME2 NULL, 
    [IsEmailVerified] BIT NULL DEFAULT 0, 
    [PhoneNumber] NVARCHAR(50) NULL, 
    [IsPhoneNumberVerified] BIT NULL DEFAULT 0, 
    [PhoneVerificationCode] NVARCHAR(200) NULL, 
    [PhoneVerificationCodeExpirationDate] DATETIME2 NULL, 
    CONSTRAINT [AK_User_Email] UNIQUE ([Email]
    ), 

)

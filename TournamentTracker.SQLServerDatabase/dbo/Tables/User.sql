CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(2000) NOT NULL, 
    [Password] NVARCHAR(800) NOT NULL, 
    [FirstName] NVARCHAR(200) NULL, 
    [LastName] NVARCHAR(200) NULL, 
    [DateOfBirth] DATETIME2 NULL, 
    [Gender] BINARY NULL
)

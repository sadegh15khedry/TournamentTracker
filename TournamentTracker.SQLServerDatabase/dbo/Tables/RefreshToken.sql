CREATE TABLE [dbo].[RefreshToken]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [Token] NVARCHAR(1000) NOT NULL, 
    [ExpireDate] DATETIME2 NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL, 
    [IsValid] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_RefreshToken_ToUser] FOREIGN KEY ([Id]) REFERENCES [User]([Id]), 
    CONSTRAINT [AK_RefreshToken_Token] UNIQUE ([Token]), 
    PRIMARY KEY ([Id])
)

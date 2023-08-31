CREATE TABLE [dbo].[Tournament]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Location] NVARCHAR(200) NULL, 
    [IsFinished] BIT NULL DEFAULT 0, 
    [IsStarted] BIT NULL DEFAULT 0, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Tournament_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)

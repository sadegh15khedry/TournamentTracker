CREATE TABLE [dbo].[Player]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SSN] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [TeamId] INT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(2000) NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Player_ToTeam] FOREIGN KEY ([TeamId]) REFERENCES [Team]([Id]), 
    CONSTRAINT [FK_Player_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]))

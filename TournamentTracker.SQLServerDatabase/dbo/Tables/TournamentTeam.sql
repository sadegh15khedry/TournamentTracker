CREATE TABLE [dbo].[TournamentTeam]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentTeam_ToTeam] FOREIGN KEY ([TeamId]) REFERENCES [Team]([Id]),
    CONSTRAINT [FK_TournamentTeam_ToTournament] FOREIGN KEY ([TournamentId]) REFERENCES [Tournament]([Id]), 
    CONSTRAINT [AK_TournamentTeam_Column] UNIQUE ([TeamId],[TournamentId]), 
    CONSTRAINT [FK_TournamentTeam_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)

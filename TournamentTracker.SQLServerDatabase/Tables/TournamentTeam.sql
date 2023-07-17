CREATE TABLE [dbo].[TournamentTeam]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL
)

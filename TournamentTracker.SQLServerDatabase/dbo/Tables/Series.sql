CREATE TABLE [dbo].[Series]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Round] INT NULL, 
    [PlaceInRound] INT NULL, 
    [isSeriesFinished] BIT NOT NULL DEFAULT 0, 
    [FirstTeamId] INT NOT NULL, 
    [SecondTeamId] INT NOT NULL, 
    [TournamentId] INT NOT NULL, 
    CONSTRAINT [FK_Series_ToTeamA] FOREIGN KEY ([FirstTeamId]) REFERENCES [Team]([Id]),
    CONSTRAINT [FK_Series_ToTeamB] FOREIGN KEY ([SecondTeamId]) REFERENCES [Team]([Id]), 
    CONSTRAINT [FK_Series_ToTable] FOREIGN KEY ([TournamentId]) REFERENCES [Tournament]([Id])
)

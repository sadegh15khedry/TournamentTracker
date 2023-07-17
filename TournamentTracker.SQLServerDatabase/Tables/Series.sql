CREATE TABLE [dbo].[Series]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Round] INT NULL, 
    [PlaceInRound] INT NULL, 
    [isSeriesFinished] BINARY(50) NULL, 
    [FirstTeamId] INT NOT NULL, 
    [SecondTeamId] INT NOT NULL
)

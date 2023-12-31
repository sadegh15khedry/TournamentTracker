﻿CREATE TABLE [dbo].[Match]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Outcome] INT NULL, 
    [FirstTeamScore] INT NULL, 
    [SecondTeamScore] INT NULL, 
    [SeriesId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Match_ToSeries] FOREIGN KEY ([SeriesId]) REFERENCES [Series]([Id]), 
    CONSTRAINT [FK_Match_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)

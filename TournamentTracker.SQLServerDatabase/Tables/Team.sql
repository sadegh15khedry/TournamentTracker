﻿CREATE TABLE [dbo].[Team]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(500) NOT NULL, 
    [City] NVARCHAR(500) NOT NULL, 
    [Owner] NVARCHAR(200) NOT NULL
)

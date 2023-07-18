CREATE TABLE [dbo].[Tournament]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Location] NVARCHAR(200) NULL
)

CREATE PROCEDURE [dbo].[spTournament_GetById]
	@Id int
AS
Begin
	SELECT Id, Name, Location,Description 
	From dbo.[Tournanment]
	where Id=@Id
End
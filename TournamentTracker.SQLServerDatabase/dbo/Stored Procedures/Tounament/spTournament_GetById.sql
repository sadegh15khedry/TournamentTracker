CREATE PROCEDURE [dbo].[spTournament_GetById]
	@Id int
AS
Begin
	SELECT Id, Name, Location,Description 
	From dbo.[Tournament]
	where Id=@Id
End
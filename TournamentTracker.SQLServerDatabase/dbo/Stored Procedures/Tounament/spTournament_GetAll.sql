CREATE PROCEDURE [dbo].[spTournament_GetAll]
AS
Begin
	SELECT Id, Name, Location,Description 
	From dbo.[Tournanment]
End
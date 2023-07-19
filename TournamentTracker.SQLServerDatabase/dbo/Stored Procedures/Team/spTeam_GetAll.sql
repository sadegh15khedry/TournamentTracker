CREATE PROCEDURE [dbo].[spTeam_GetAll]
As
Begin
	SELECT Id, Name, City, Owner From dbo.[Team]
End

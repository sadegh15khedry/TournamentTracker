CREATE PROCEDURE [dbo].[spPlayer_GetFreeAgentPlayers]
AS
Begin
	SELECT Id, SSN, FirstName, LastName, TeamId, Phone, Email From dbo.[Player]
	Where TeamId IS Null
End

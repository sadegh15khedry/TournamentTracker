CREATE PROCEDURE [dbo].[spPlayer_GetFreeAgentPlayers]
	@UserId int
AS
Begin
	SELECT Id, SSN, FirstName, LastName, TeamId, Phone, Email From dbo.[Player]
	Where TeamId IS Null and UserId = @UserId
End

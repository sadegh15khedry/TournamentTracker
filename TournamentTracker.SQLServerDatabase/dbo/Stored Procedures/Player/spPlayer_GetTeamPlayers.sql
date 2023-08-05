CREATE PROCEDURE [dbo].[spPlayer_GetTeamPlayers]
	@TeamId int 
AS
Begin
	SELECT Id, SSN, FirstName, LastName, Phone, TeamId ,Email From dbo.[Player]
	Where TeamId = @TeamId
End

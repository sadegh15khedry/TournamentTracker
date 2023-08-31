CREATE PROCEDURE [dbo].[spPlayer_SignedWithTeam]
	@PlayerId int,
	@TeamId int,
	@UserId int

AS
begin

	Update dbo.[Player] Set TeamId = @TeamId
	Output Inserted.Id, Inserted.SSN, Inserted.FirstName, Inserted.LastName,
	Inserted.TeamId, Inserted.Phone, Inserted.Email
	Where Id = @PlayerId and UserId = @UserId
End

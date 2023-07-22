CREATE PROCEDURE [dbo].[spPlayer_SignedWithTeam]
	@PlayerId int,
	@TeamId int
AS
begin

	Update dbo.[Player] Set TeamId = @TeamId
	Where Id = @PlayerId  
End

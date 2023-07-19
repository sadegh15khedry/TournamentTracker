CREATE PROCEDURE [dbo].[SpPlayer_GetById]
	@Id int
AS
Begin
	SELECT Id, SSN, FirstName, LastName, TeamId, Phone, Email
	From dbo.[Player]
	Where Id = @Id
End

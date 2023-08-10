CREATE PROCEDURE [dbo].[spPlayer_CanceledContract]
	@Id int
AS
Begin
	Update dbo.[Player] Set TeamId = null 
	output Inserted.Id, Inserted.SSN, Inserted.FirstName, Inserted.LastName,
	Inserted.TeamId, Inserted.Phone, Inserted.Email 
	Where Id = @Id
End

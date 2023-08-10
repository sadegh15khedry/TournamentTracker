CREATE PROCEDURE [dbo].[spPlayer_Delete]
	@Id int
AS
Begin
	Delete From dbo.[Player]
	Output Deleted.Id, Deleted.SSN, Deleted.FirstName, Deleted.LastName, 
	Deleted.TEamId, Deleted.Phone, Deleted.Email
	Where Id = @Id
End

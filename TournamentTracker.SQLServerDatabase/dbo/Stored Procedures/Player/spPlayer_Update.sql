CREATE PROCEDURE [dbo].[spPlayer_Update]
	@Id int,
	@SSN  nvarchar(50),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Phone nvarchar(50),
	@Email nvarchar(50)
AS
Begin
	Update dbo.[Player] 
	Set SSN = @SSN, FirstName = @FirstName, LastName = @LastName,
	Phone = @Phone, Email = @Email
	Output Inserted.Id, Inserted.SSN, Inserted.FirstName, Inserted.LastName,
	Inserted.TeamId, Inserted.Phone, Inserted.Email
	Where Id = @Id
End

CREATE PROCEDURE [dbo].[spPlayer_Insert]
	@SSN  nvarchar(50),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Phone nvarchar(50),
	@Email nvarchar(50),
	@UserId int
AS
Begin
	Insert Into dbo.[Player]
		(SSN, FirstName, LastName, TeamId, Phone, Email, UserId)
	output
	Inserted.SSN,
	Inserted.FirstName,
	Inserted.LastName,
	Inserted.TeamId,
	Inserted.Phone,
	Inserted.Email
	Values
		(@SSN, @FirstName, @LastName, Null, @Phone, @Email, @UserId)
End

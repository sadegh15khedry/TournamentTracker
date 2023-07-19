CREATE PROCEDURE [dbo].[spPlayer_Insert]
	@SSN  nvarchar(50),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Phone nvarchar(50),
	@Email nvarchar(50)
AS
Begin
	Insert Into dbo.[Player] (SSN, FirstName, LastName, TeamId, Phone, Email)
	Values (@SSN, @FirstName, @LastName, Null, @Phone, @Email)
End

CREATE PROCEDURE [dbo].[spRefreshToken_Insert]
	@UserId int,
	@Token nvarchar(1000),
	@ExpireDate dateTime2,
	@CreateDate DateTime2
AS
Begin
	Insert Into dbo.[RefreshToken] (UserId, Token, ExpireDate, CreateDate, IsValid)
	Output inserted.Id, inserted.UserId, inserted.Token, inserted.ExpireDate, inserted.CreateDate
	Values (@UserId, @Token, @ExpireDate, @CreateDate, 1 )
End

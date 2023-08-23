CREATE PROCEDURE [dbo].[spRefreshToken_GetByToken]
	@Token nvarchar(1000)
AS
Begin
	SELECT Id, UserId, Token, ExpireDate, CreateDate, IsValid From dbo.[RefreshToken]
	where Token = @Token
End

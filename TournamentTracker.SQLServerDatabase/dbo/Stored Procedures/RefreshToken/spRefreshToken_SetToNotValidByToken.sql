CREATE PROCEDURE [dbo].[spRefreshToken_SetToNotValidByToken]
	@Token nvarchar(1000)
AS
Begin
	Update dbo.[RefreshToken] Set IsValid = 0
	output Inserted.Id, Inserted.UserId, Inserted.Token, Inserted.ExpireDate,
	Inserted.CreateDate, Inserted.IsValid 
	where Token = @Token
End

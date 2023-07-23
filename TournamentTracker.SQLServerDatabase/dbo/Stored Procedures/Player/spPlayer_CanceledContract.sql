CREATE PROCEDURE [dbo].[spPlayer_CanceledContract]
	@Id int
AS
Begin
	Update dbo.[Player] Set TeamId = null 
	Where Id = @Id
End

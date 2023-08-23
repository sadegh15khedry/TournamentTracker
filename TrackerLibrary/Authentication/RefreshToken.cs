namespace TournamentTrackerLibrary.Authentication;

public class RefreshToken
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Token { get; set; } = string.Empty;
    public DateTime ExpireDate { get; set; }
    public DateTime CreateDate { get; set; }
    public bool isValid { get; set; } = true;
}

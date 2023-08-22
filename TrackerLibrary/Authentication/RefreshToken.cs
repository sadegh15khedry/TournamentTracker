namespace TournamentTrackerLibrary.Authentication;

public class RefreshToken
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Token { get; set; } = string.Empty;
    public DateTime DateTimeCreated { get; set; }
    public DateTime DateTimeExpires { get; set; }
    public bool isValid { get; set; } = true;
}

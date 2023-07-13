namespace TrackerLibrary;

public class Player
{
    /// <summary>
    /// Automaticly generated Id for Player
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// First name of the player
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// last name of the player
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// social sercurity number of the player
    /// </summary>
    public string? SSN { get; set; }

    /// <summary>
    /// phone number of the player
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// the team of the player 
    /// </summary>
    public Team Team { get; set; }


}

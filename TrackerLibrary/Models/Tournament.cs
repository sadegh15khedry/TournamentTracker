namespace TournamentTrackerLibrary.Models;

public class Tournament
{

    /// <summary>
    /// Autmaticly generated Identifier for Tournament
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the Tournament
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Simple and short descrption of the Tournament. 
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The location of The tournament  
    /// </summary>
    public string? Location { get; set; }


    public bool? IsFinished { get; set; } = false;

    public bool? IsStarted { get; set; } = false;


    /// <summary>
    /// List of Teams that participate in the tournament.  
    /// </summary>
    public List<Team>? Teams { get; set; } = new List<Team>();

    /// <summary>
    /// the team that won the tournament.
    /// </summary>
    public Team? WinnerTeam { get; set; } = new Team();

    /// <summary>
    /// List of Matches in The tournament 
    /// </summary>
    public List<Series>? Series { get; set; }



}

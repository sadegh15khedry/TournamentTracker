namespace TournamentTrackerLibrary.Models;

public class Series
{
    /// <summary>
    /// Automaticly generated Identifier for Series
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Determines the round of the series in the tournament
    /// 0 for finals
    /// 1 for semi finals 
    /// and so on 
    /// </summary>
    public int Round { get; set; }

    /// <summary>
    /// Determines placement of two teams in tournament posetive numbers for the right side
    /// and negetive numbers for left side of chart.
    /// the winer of the placInRound = 1 and placeInRound = 2 in the current round play eachother 
    /// in the next round and the same for -1 and -2 in the left side of the chart
    /// </summary>
    public int PlaceInRound { get; set; }

    /// <summary>
    /// Determines if the series has been finished.
    /// </summary>
    public bool? IsSeriesEnded { get; set; } = false;

    /// <summary>
    /// Id of the FirstTeam participating in the Series
    /// </summary>
    public int FirstTeamId { get; set; }

    /// <summary>
    /// Id of the SecondTeam participating in the Series
    /// </summary>
    public int SecondTeamId { get; set; }

    /// <summary>
    /// Id of the Series Tournament 
    /// </summary>
    public int TournamentId { get; set; }



    /// <summary>
    /// First Team that participated in the series
    /// </summary>
    public Team? FirstTeam { get; set; } = new Team();

    /// <summary>
    /// Second Team that participated in the series
    /// </summary>
    public Team? SecondTeam { get; set; } = new Team();


    /// <summary>
    ///Tournament of the Series 
    /// </summary>
    //public Tournament? Tournament { get; set; }

    /// <summary>
    ///list of matches in the series 
    /// </summary>
    public List<Match>? Matches { get; set; } = new List<Match>();

    /// <summary>
    /// wins count of First Team in the series
    /// </summary>
    public int? FirstTeamWins { get; set; }

    /// <summary>
    /// wins count of Second Team in the series
    /// </summary>
    public int? SecondTeamWins { get; set; }
}

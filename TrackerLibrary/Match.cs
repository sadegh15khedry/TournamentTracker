namespace TrackerLibrary;

public class Match
{

    /// <summary>
    /// Autmaticly generated Identifier for Match
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Detemines who won the Match 
    /// 0 Means Tie 
    /// 1 Means first team has won
    /// 2 Means second team has won
    /// </summary>
    public int Outcome { get; set; }

    /// <summary>
    /// Score of the First team in the match
    /// </summary>
    public int FirstTeamScore { get; set; }

    /// <summary>
    /// Score of the First team in the match
    /// </summary>
    public int SecondTeamScore { get; set; }

    public int SeriesId { get; set; }

    public int MyProperty { get; set; }
}

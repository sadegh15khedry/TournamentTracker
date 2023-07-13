﻿namespace TrackerLibrary;

public class Tournament
{
    
    /// <summary>
    /// Autmaticly generated Identifier for Tournament
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Name of the Tournament
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Simple and short descrption of the Tournament. 
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// The location of The tournament  
    /// </summary>
    public string? Location { get; set; }
    
    /// <summary>
    /// List of Teams that participate in the tournament.  
    /// </summary>
    public List<Team> Teams { get; set; }
    
    /// <summary>
    /// the team that won the tournametn.
    /// </summary>
    public Team WinnerTeam { get; set; }

    /// <summary>
    /// List of Matches in The tournamet 
    /// </summary>
    public List<Match> Matches { get; set; }

}

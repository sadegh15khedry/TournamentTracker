﻿namespace TournamentTrackerLibrary.Models;

public class Team
{
    /// <summary>
    /// Id of the team
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// name of the Team 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// city that the team is loacated 
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// first name and last name of the owner
    /// </summary>
    public string Owner { get; set; } = string.Empty;
    public int UserId { get; set; }

}

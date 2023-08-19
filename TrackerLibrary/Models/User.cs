﻿namespace TournamentTrackerLibrary.Models;

public class User
{

    /// <summary>
    /// Autmaticly generated Identifier for Users
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// First Name of The user
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Last name of the user
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Email Address of the user.
    /// also used as Identifier for users 
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; } = string.Empty;
    //public byte? HashedPassword { get; set; }

    public string? Role { get; set; } = string.Empty;

}

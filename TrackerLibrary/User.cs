namespace TrackerLibrary;

public class User
{

    /// <summary>
    /// Autmaticly generated Identifier for Users
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// First Name of The user
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of the user
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Email Address of the user.
    /// also used as Identifer for users 
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Password of the user.
    /// </summary>
    public string Password { get; set; }

}

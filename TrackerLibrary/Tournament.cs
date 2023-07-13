namespace TrackerLibrary;

public class Tournament
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public List<Team> Teams { get; set; }
    public Team WinnerTeam { get; set; }

}

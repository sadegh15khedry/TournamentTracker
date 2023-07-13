namespace TrackerLibrary;

public class Match
{
    public int Id { get; set; }
    public int Outcome { get; set; }
    public Team FirstTeam { get; set; } = new Team();
    public Team SecondTeam { get; set; } = new Team();

}

using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class Tournaments : Form
{

    private readonly ITournamentData _data;
    public Tournaments(ITournamentData data)
    {
        InitializeComponent();
        _data = data;
    }


    private void goToAddTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AddTournament().ShowDialog();
    }

    private void goToTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new TournamentTeamSelection().ShowDialog();
    }

    private void Tournaments_Load(object sender, EventArgs e)
    {

        //_data = sender.g

        var tournaments = _data.GetAll().Result;
        tournamentsComboBox.Items.Add(tournaments.ToString());
    }
}

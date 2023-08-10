using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TournamentsForm : Form
{

    private readonly ITournamentData _tournamentData;
    public List<Tournament> TournamentsList { get; set; }
    public int SelectedTournamentId { get; set; } = -1;

    public TournamentsForm(ITournamentData data)
    {
        InitializeComponent();
        _tournamentData = data;
        TournamentsList = _tournamentData.GetAll().Result;
        //MessageBox.Show(_data.GetAll().Result.First().Name);
    }


    private void goToAddTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateAddTournamentForm().Show();
    }

    private void goToTournamentButton_Click(object sender, EventArgs e)
    {
        if (SelectedTournamentId != -1)
        {
            this.Hide();
            FormFactory.CreateTournamentTeamSelectForm(SelectedTournamentId).Show();
        }
    }

    private void Tournaments_Load(object sender, EventArgs e)
    {
        foreach (Tournament tournament in TournamentsList)
            tournamentsComboBox.Items.Add(tournament.Name.ToString());
    }

    private void tournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedIndex = tournamentsComboBox.SelectedIndex;
        SelectedTournamentId = TournamentsList.ElementAtOrDefault(selectedIndex)!.Id;
    }
}

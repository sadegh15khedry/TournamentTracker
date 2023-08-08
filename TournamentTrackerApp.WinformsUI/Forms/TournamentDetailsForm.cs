using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TournamentDetailsForm : Form
{

    private readonly IPlayerData _playerData;
    public Player SelectedPlayer { get; set; }

    public TournamentDetailsForm(ITournamentData tournamentData, int tournamentId)
    {
        InitializeComponent();
        PageSetup();

    }

    public void PageSetup()
    {
        idValueLabel.Text = SelectedPlayer.Id.ToString();
        firstNameValueLabel.Text = SelectedPlayer.FirstName;
        lastNameValueLabel.Text = SelectedPlayer.LastName;
        SSNValueLabel.Text = SelectedPlayer.SSN;
        emailValueLabel.Text = SelectedPlayer.Email;
        phoneValueLabel.Text = SelectedPlayer.Phone;

        if (SelectedPlayer.Team is not null)
        {
            teamValueLabel.Text = SelectedPlayer.Team.Name;
        }
        else
        {
            teamValueLabel.Text = "Free Agent";
        }
    }

    private void editPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateEditPlayerForm(SelectedPlayer.Id).Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateHomeForm().Show();
    }
}

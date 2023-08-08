using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class EditTeamForm : Form
{
    private readonly ITeamData _teamData;
    public Team SelectedTeam { get; set; }
    public EditTeamForm(ITeamData teamData, int teamId)
    {
        InitializeComponent();
        _teamData = teamData;
        SelectedTeam = _teamData.GetById(teamId).Result;
        PageSetup();
    }
    private void PageSetup()
    {
        nameTextBox.Text = SelectedTeam.Name;
        cityTextBox.Text = SelectedTeam.City;
        ownerTextBox.Text = ownerTextBox.Text;
    }

    private void EditTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        SelectedTeam.Name = nameTextBox.Text;
        SelectedTeam.City = cityTextBox.Text;
        SelectedTeam.Owner = ownerTextBox.Text;

        _teamData.Update(SelectedTeam);
        Thread.Sleep(100);
        FormFactory.CreateTeamDetailsForm(SelectedTeam.Id).Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTeamDetailsForm(SelectedTeam.Id).Show();
    }
}

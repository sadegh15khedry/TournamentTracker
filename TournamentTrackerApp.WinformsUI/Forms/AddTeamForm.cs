using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class AddTeamForm : Form
{
    private readonly ITeamData _teamData;

    public AddTeamForm(ITeamData teamData)
    {
        InitializeComponent();
        _teamData = teamData;
    }

    private void createTeamButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        Team team = new Team()
        {
            Name = nameTextBox.Text,
            City = cityTextBox.Text,
            Owner = ownerTextBox.Text,
        };
        var insertedTeam = _teamData.Insert(team).Result;
        Thread.Sleep(100);
        //MessageBox.Show(insertedTeam.Id.ToString());
        FormFactory.CreateHomeForm().Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateHomeForm().Show();
    }
}

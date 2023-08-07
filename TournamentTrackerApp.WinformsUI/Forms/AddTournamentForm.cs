using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class AddTournamentForm : Form
{
    private readonly ITournamentData _tournamentData;

    public AddTournamentForm(ITournamentData _tournamentData)
    {
        InitializeComponent();
        this._tournamentData = _tournamentData;
    }

    private void createTournamentButton_Click(object sender, EventArgs e)
    {
        Tournament newTournament = new Tournament()
        {
            Name = nameTextBox.Text,
            Description = descriptionTextBox.Text,
            Location = locationTextBox.Text
        };

        _tournamentData.Create(newTournament);
        this.Hide();
        Thread.Sleep(100);
        FormFactory.CreateHomeForm().Show();
    }
}

using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class EditTournamentForm : Form
{
    private readonly ITournamentData _tournamentData;

    public Tournament SelectedTournament { get; private set; }

    public EditTournamentForm(ITournamentData _tournamentData, int tournamentId)
    {
        InitializeComponent();
        this._tournamentData = _tournamentData;
        SelectedTournament = _tournamentData.GetById(tournamentId).Result;
        PageSetup();
    }

    private void PageSetup()
    {
        nameTextBox.Text = SelectedTournament.Name;
        locationTextBox.Text = SelectedTournament.Location;
        descriptionTextBox.Text = SelectedTournament.Description;
    }

    private void editTournamentButton_Click(object sender, EventArgs e)
    {
        SelectedTournament.Name = nameTextBox.Text;
        SelectedTournament.Description = descriptionTextBox.Text;
        SelectedTournament.Location = locationTextBox.Text;

        _tournamentData.Update(SelectedTournament);
        this.Hide();
        Thread.Sleep(100);
        FormFactory.CreateTournamentDetails(SelectedTournament.Id).Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentDetails(SelectedTournament.Id).Show();
    }
}

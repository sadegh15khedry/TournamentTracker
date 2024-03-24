using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TournamentDetailsForm : Form
{
    private readonly ITournamentData _tournamentData;
    public Tournament SelectedTournament { get; set; }

    public TournamentDetailsForm(ITournamentData _tournamentData, int tournamentId)
    {
        InitializeComponent();
        this._tournamentData = _tournamentData;
        SelectedTournament = _tournamentData.GetById(tournamentId).Result;
        PageSetup();
    }

    private void PageSetup()
    {
        nameValueLabel.Text = SelectedTournament.Name;
        locationValueLabel.Text = SelectedTournament.Location;
        descriptionValueLabel.Text = SelectedTournament.Description;
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateHomeForm().Show();
    }

    private void TournamentTeamsButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentTeamSelectForm(SelectedTournament.Id).Show();
    }

    private void EditTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateEditTournamentForm(SelectedTournament.Id).Show();
    }

    private void startTournamentButton_Click(object sender, EventArgs e)
    {
        if (SelectedTournament.IsStarted == true)
        {
            this.Hide();
            FormFactory.CreateTournamentChart(SelectedTournament.Id).Show();
            return;
        }
        var result = _tournamentData.SetToStarted(SelectedTournament.Id);
        /*if (result == false)
        {*/
        /*MessageBox.Show("start conditions did not met. check tournament teams.");
        return;*/
        /*}*/

        this.Hide();
        FormFactory.CreateTournamentChart(SelectedTournament.Id).Show();

    }


}

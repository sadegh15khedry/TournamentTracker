using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class SeriesDetailsForm : Form
{
    private readonly ISeriesData _seriesData;
    public Series SelectedSeries { get; set; }

    public SeriesDetailsForm(ISeriesData seriesData, int seriesId)
    {
        InitializeComponent();
        _seriesData = seriesData;
        SelectedSeries = _seriesData.GetById(seriesId).Result;
        DisplayPageData();
    }

    private void DisplayPageData()
    {
        firstTeamNameLabel.Text = SelectedSeries.FirstTeam.Name;
        secondTeamNameLabel.Text = SelectedSeries.SecondTeam.Name;
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentChart(SelectedSeries.TournamentId).Show();
    }
}

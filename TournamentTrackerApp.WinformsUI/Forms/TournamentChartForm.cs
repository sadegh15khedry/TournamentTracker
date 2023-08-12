using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TournamentChartForm : Form
{
    private readonly ITournamentData _tournamentData;
    private readonly ITeamData _teamData;
    private readonly ISeriesData _seriesData;
    public Tournament SelectedTournament { get; set; }


    public TournamentChartForm(ITournamentData tournamentData, ITeamData teamData,
        ISeriesData seriesData, int tournamentId)
    {
        InitializeComponent();
        _tournamentData = tournamentData;
        _teamData = teamData;
        _seriesData = seriesData;
        SelectedTournament = _tournamentData.GetById(tournamentId).Result;

        PageSetup();
    }

    private void PageSetup()
    {
        titleLabel.Text = SelectedTournament.Name;
        ClearLabels();
        titleLabel.Text = SelectedTournament.Name;
        backButton.Text = "←";

        MessageBox.Show(SelectedTournament.Teams.Count.ToString());
        MessageBox.Show(SelectedTournament.Series.Count.ToString());

        if (SelectedTournament.Series.Count == 0)
        {
            SelectedTournament.Series = _tournamentData
                .GenerateSeries(SelectedTournament.Id).Result;
        }

        foreach (var series in SelectedTournament.Series)
        {
            DisplaySeriesInChart(series);
        }


    }

    private void DisplaySeriesInChart(Series series)
    {
        MessageBox.Show(series.FirstTeam.Name);

        if (series.Round == 1 && series.PlaceInRound == 1)

        {
            teamABCDLabel.Text = series.FirstTeam.Name;
            teamEFGHLabel.Text = series.SecondTeam.Name;
            abcdVefghLabel.Text = "X";
        }
        else if (series.Round == 1 && series.PlaceInRound == 2)
        {
            teamIJKLLabel.Text = series.FirstTeam.Name;
            teamMNOPLabel.Text = series.SecondTeam.Name;
            ijklVmnopLabel.Text = "X";
        }

    }





    private void ClearLabels()
    {
        var labels = Controls.OfType<Label>();
        foreach (var label in labels)
        {
            label.Text = string.Empty;
        }
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentDetails(SelectedTournament.Id).Show();
    }

}

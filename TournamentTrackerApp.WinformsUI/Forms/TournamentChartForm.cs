using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
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
            InitializeTournamentSeries();
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

    private void InitializeTournamentSeries()
    {
        SelectedTournament.Teams = SelectedTournament.Teams.OrderBy(s => Guid.NewGuid()).ToList();
        int round = GetTournamentSeriesRound(SelectedTournament.Teams.Count / 2);
        int placeInRound = 1;
        for (int i = 0; i < SelectedTournament.Teams.Count; i += 2)
        {
            Series series = new Series()
            {
                TournamentId = SelectedTournament.Id,
                FirstTeamId = SelectedTournament.Teams[i].Id,
                SecondTeamId = SelectedTournament.Teams[i + 1].Id,
                IsSeriesEnded = false,
                Round = round,
                PlaceInRound = placeInRound
            };
            _seriesData.Create(series);
            placeInRound++;
        }
        this.Hide();
        Thread.Sleep(200);
        FormFactory.CreateTournamentChart(SelectedTournament.Id).Show();
    }

    private int GetTournamentSeriesRound(int seriesCount)
    {

        MessageBox.Show("round is =  " + seriesCount.ToString());
        if (seriesCount == 1)
        {
            return 0;
        }
        else if (seriesCount == 2)
        {
            return 1;
        }
        else if (seriesCount == 8)
        {
            return 3;
        }
        else
        {
            return -1;
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

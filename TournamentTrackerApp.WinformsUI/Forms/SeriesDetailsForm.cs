using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class SeriesDetailsForm : Form
{
    private readonly IMatchData _matchData;
    private readonly ISeriesData _seriesData;
    public Series SelectedSeries { get; set; }

    public SeriesDetailsForm(IMatchData matchData, ISeriesData seriesData, int seriesId)
    {
        InitializeComponent();
        _matchData = matchData;
        _seriesData = seriesData;
        SelectedSeries = _seriesData.GetById(seriesId).Result;
        DisplayPageData();
    }

    private void DisplayPageData()
    {
        firstTeamNameLabel.Text = SelectedSeries.FirstTeam.Name;
        secondTeamNameLabel.Text = SelectedSeries.SecondTeam.Name;
        firstTeamWinsLabel.Text = SelectedSeries.FirstTeamWins.ToString();
        secondTeamWinsLabel.Text = SelectedSeries.SecondTeamWins.ToString();

        int matchesPlayed = SelectedSeries.Matches.Count();

        HideAllScores();

        if (matchesPlayed > 0)
        {
            firstMatchFirstTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(0).FirstTeamScore.ToString();
            firstMatchSecondTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(0).SecondTeamScore.ToString();
            firstMatchVsLabel.Text = "vs";

        }

        if (matchesPlayed > 1)
        {
            SecondMatchFirstTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(1).FirstTeamScore.ToString();
            secondMatchSecondTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(1).SecondTeamScore.ToString();
            secondMatchVsLabel.Text = "vs";
        }
        if (matchesPlayed > 2)
        {
            thirdMatchFirstTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(2).FirstTeamScore.ToString();
            thirdMatchSecondTeamScoreLabel.Text = SelectedSeries.Matches.ElementAt(2).SecondTeamScore.ToString();
            thirdMatchVsLabel.Text = "vs";

            //maximum matches in series reached
            firstTeamScoreTextBox.Hide();
            secondTeamScoreTextBox.Hide();
            submitMatchButton.Hide();
        }


    }

    private void HideAllScores()
    {
        firstMatchFirstTeamScoreLabel.Text = ""; ;
        firstMatchSecondTeamScoreLabel.Text = ""; ;
        SecondMatchFirstTeamScoreLabel.Text = ""; ;
        secondMatchSecondTeamScoreLabel.Text = ""; ;
        thirdMatchFirstTeamScoreLabel.Text = ""; ;
        thirdMatchSecondTeamScoreLabel.Text = ""; ;
        firstMatchVsLabel.Text = "";
        secondMatchVsLabel.Text = "";
        thirdMatchVsLabel.Text = "";
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentChart(SelectedSeries.TournamentId).Show();
    }

    private void submitMatchButton_Click(object sender, EventArgs e)
    {
        _matchData.Create(new Match()
        {
            FirstTeamScore = Int32.Parse(firstTeamScoreTextBox.Text),
            SecondTeamScore = Int32.Parse(secondTeamScoreTextBox.Text),
            SeriesId = SelectedSeries.Id

        });
        this.Hide();
        Thread.Sleep(100);
        FormFactory.CreateSeriesDetailsForm(SelectedSeries.Id).Show();
    }
}

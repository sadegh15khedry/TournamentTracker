using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TournamentChartForm : Form
{
    private readonly ITournamentData _tournamentData;
    private readonly int _tournamentId;

    public Tournament SelectedTournament { get; set; }


    public TournamentChartForm(ITournamentData tournamentData, int tournamentId)
    {
        InitializeComponent();
        _tournamentData = tournamentData;
        _tournamentId = tournamentId;
        ClearLabels();
        //Thread.Sleep(2000);

    }

    private void PageSetup()
    {
        ClearLabels();
        titleLabel.Text = SelectedTournament.Name;
        backButton.Text = "←";

        //MessageBox.Show(SelectedTournament.Teams.Count.ToString());
        //MessageBox.Show(SelectedTournament.Series.Count.ToString());

        if (SelectedTournament.IsStarted == false)
        {
            MessageBox.Show("tournament has not been started please check requirements.");
        }
        else
        {
            DisplaySeriesInChart();
        }



    }

    private void DisplaySeriesInChart()
    {
        // MessageBox.Show()

        foreach (var series in SelectedTournament.Series)
        {

            //finals
            if (series.Round == 0 && series.PlaceInRound == 1)
            {
                teamEastLabel.Text = series.FirstTeam.Name + "\n" + series.FirstTeamWins.ToString();
                teamWestLabel.Text = series.SecondTeam.Name + "\n" + series.SecondTeamWins.ToString();

                finalsVLabel.Text = "X";
                finalsVLabel.Click += (sender, e) => { GoToSeries(series.Id); };
            }
            //conference finals
            else if (series.Round == 1 && series.PlaceInRound == 1)
            {
                teamABCDLabel.Text = series.FirstTeamWins.ToString() + "  " +
                    series.FirstTeam.Name;

                teamEFGHLabel.Text = series.SecondTeamWins.ToString() +
                    "  " + series.SecondTeam.Name;

                abcdVefghLabel.Text = "X";
                abcdVefghLabel.Click += (sender, e) => { GoToSeries(series.Id); };

            }
            else if (series.Round == 1 && series.PlaceInRound == 2)
            {
                teamIJKLLabel.Text = series.FirstTeam.Name + "  " + series.FirstTeamWins.ToString();
                teamMNOPLabel.Text = series.SecondTeam.Name + "  " + series.SecondTeamWins.ToString();

                ijklVmnopLabel.Text = "X";
                ijklVmnopLabel.Click += (sender, e) => { GoToSeries(series.Id); };
            }
            //second round
            else if (series.Round == 2 && series.PlaceInRound == 1)
            {
                teamABLabel.Text = series.FirstTeam.Name;
                teamCDLabel.Text = series.SecondTeam.Name;

                abcdVefghLabel.Text = "X";
                ijklVmnopLabel.Click += (sender, e) => { GoToSeries(series.Id); };
            }



            //first round
        }



    }


    private void GoToSeries(int seriesId)
    {
        this.Hide();
        FormFactory.CreateSeriesDetailsForm(seriesId).Show();
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

    private async void TournamentChartForm_Load(object sender, EventArgs e)
    {
        SelectedTournament = await _tournamentData.GetById(_tournamentId);
        PageSetup();
    }
}

using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TournamentChartForm : Form
{
    private readonly ITournamentData _tournamentData;

    public Tournament SelectedTournament { get; set; }


    public TournamentChartForm(ITournamentData tournamentData, int tournamentId)
    {
        InitializeComponent();
        _tournamentData = tournamentData;
        SelectedTournament = _tournamentData.GetById(tournamentId).Result;


        PageSetup();
    }

    private void PageSetup()
    {
        ClearLabels();
        titleLabel.Text = SelectedTournament.Name;
        backButton.Text = "←";

        MessageBox.Show(SelectedTournament.Teams.Count.ToString());
        MessageBox.Show(SelectedTournament.Series.Count.ToString());

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
            if (series.Round == 1 && series.PlaceInRound == 1)

            {
                MessageBox.Show(teamABCDLabel.Text);
                MessageBox.Show(teamEFGHLabel.Text);

                teamABCDLabel.Text = series.FirstTeam.Name;
                teamEFGHLabel.Text = series.SecondTeam.Name;
                abcdVefghLabel.Text = "X";
                abcdVefghLabel.Click += (sender, e) => { GoToSeries(series.Id); };

            }
            else if (series.Round == 1 && series.PlaceInRound == 2)
            {
                teamIJKLLabel.Text = series.FirstTeam.Name;
                teamMNOPLabel.Text = series.SecondTeam.Name;
                ijklVmnopLabel.Text = "X";
                ijklVmnopLabel.Click += (sender, e) => { GoToSeries(series.Id); };
            }
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

}

﻿using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TournamentChartForm : Form
{
    private readonly ITournamentData _tournamentData;
    private readonly ITeamData _teamData;
    private readonly ISeriesData _seriesData;
    public Tournament SelectedTournament { get; set; }
    public List<Team> TournamentTeams { get; set; }

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
    }

    private void ClearLabels()
    {
        var labels = Controls.OfType<Label>();
        foreach (var label in labels)
        {
            label.Text = string.Empty;
        }
    }
}

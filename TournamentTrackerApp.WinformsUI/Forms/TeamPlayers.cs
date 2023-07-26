﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class TeamPlayers : Form
{
    public TeamPlayers()
    {
        InitializeComponent();
    }

    private void goToAddPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AddPlayer().ShowDialog();
    }

    private void doneButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new TournamentTeamSelection().ShowDialog();
    }
}

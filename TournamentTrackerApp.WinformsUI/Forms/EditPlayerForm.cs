using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class EditPlayerForm : Form
{
    private readonly IPlayerData _playerData;
    public Player SelectedPlayer { get; set; }

    public EditPlayerForm(IPlayerData playerData, int playerId)
    {
        InitializeComponent();
        _playerData = playerData;
        SelectedPlayer = _playerData.GetById(playerId).Result;
        PageSetup();
    }
    private void PageSetup()
    {
        firstnameTextBox.Text = SelectedPlayer.FirstName;
        lastnameTextBox.Text = SelectedPlayer.LastName;
        ssnTextBox.Text = SelectedPlayer.SSN;
        phoneTextBox.Text = SelectedPlayer.Phone;
        emailTextBox.Text = SelectedPlayer.Email;
    }

    private void EditPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();

        SelectedPlayer.FirstName = firstnameTextBox.Text;
        SelectedPlayer.LastName = lastnameTextBox.Text;
        SelectedPlayer.SSN = ssnTextBox.Text;
        SelectedPlayer.Phone = phoneTextBox.Text;
        SelectedPlayer.Email = emailTextBox.Text;

        _playerData.Update(SelectedPlayer);
        //MessageBox.Show(response.Result.ToString());
        Thread.Sleep(100);
        FormFactory.CreateHomeForm().Show();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreatePlayerDetailForm(SelectedPlayer.Id).Show();
    }
}

using TournamentTrackerApp.WinformsUI.Factory;
using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class AddPlayerForm : Form
{
    private readonly IPlayerData _playerData;

    public AddPlayerForm(IPlayerData playerData)
    {
        InitializeComponent();
        _playerData = playerData;
    }

    private void createPlayerButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        _playerData.Create(new Player()
        {
            FirstName = firstnameTextBox.Text,
            LastName = lastnameTextBox.Text,
            SSN = ssnTextBox.Text,
            Phone = phoneTextBox.Text
        });
        Thread.Sleep(100);
        FormFactory.CreateHomeForm().Show();
    }
}

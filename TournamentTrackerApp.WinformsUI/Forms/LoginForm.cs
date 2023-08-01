using TournamentTrackerApp.WinformsUI.Factory;

namespace TournamentTrackerApp.WinformsUI;

public partial class LoginForm : Form
{

    public LoginForm()
    {
        InitializeComponent();
    }


    private void loginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentsForm().Show();
    }

    private void toSignupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateSignupForm().Show();
    }
}

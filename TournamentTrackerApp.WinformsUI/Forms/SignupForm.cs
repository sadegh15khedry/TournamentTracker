using TournamentTrackerApp.WinformsUI.Factory;

namespace TournamentTrackerApp.WinformsUI;

public partial class SignupForm : Form
{
    private LoginForm _login;
    public SignupForm()
    {
        InitializeComponent();
    }

    private void toLoginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateLoginForm().Show();

    }

    private void signupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateTournamentsForm().Show();
        //new Tournaments().ShowDialog();
    }
}

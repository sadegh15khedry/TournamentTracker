using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class Login : Form
{

    public Login(ITeamData teamData, Tournaments tournaments)
    {
        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        //new Tournaments().ShowDialog();
    }

    private void toSignupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new Signup(this).ShowDialog();
    }
}

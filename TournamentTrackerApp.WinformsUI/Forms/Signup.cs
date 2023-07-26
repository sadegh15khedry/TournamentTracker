namespace TournamentTrackerApp.WinformsUI;

public partial class Signup : Form
{
    public Signup()
    {
        InitializeComponent();
    }

    private void toLoginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new Login().ShowDialog();
    }

    private void signupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new Tournaments().ShowDialog();
    }
}

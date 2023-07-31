namespace TournamentTrackerApp.WinformsUI;

public partial class SignupForm : Form
{
    private LoginForm _login;
    public SignupForm(LoginForm login)
    {
        InitializeComponent();
        //_login = login;
    }

    private void toLoginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        //Application.Run(ServiceProvider.GetRequiredService<Login>());
        //_login.Show();
        //new Login().ShowDialog();

    }

    private void signupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        //new Tournaments().ShowDialog();
    }
}

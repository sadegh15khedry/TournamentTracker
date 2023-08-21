using TournamentTrackerApp.WinformsUI.Factory;
using UI.DataAccess.Refit.InterFaces;
using UI.DataAccess.Refit.Stores;

namespace TournamentTrackerApp.WinformsUI;

public partial class LoginForm : Form
{
    private readonly IUserData _userData;

    public LoginForm(IUserData userData)
    {
        InitializeComponent();
        _userData = userData;
    }


    private async void loginButton_ClickAsync(object sender, EventArgs e)
    {
        this.Hide();
        string result = await _userData.Login(emailTextBox.Text, passwordTextBox.Text);
        result.Remove(0);
        result.Remove(1);
        result = result.Substring(1, result.Length - 2);


        TokenStore.AccessToken = result;
        MessageBox.Show(result);
        FormFactory.CreateHomeForm().Show();
    }

    private void toSignupButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateSignupForm().Show();
    }
}

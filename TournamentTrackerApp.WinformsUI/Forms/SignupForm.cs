using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerLibrary.Models;
using UI.DataAccess.Refit.InterFaces;
using UI.DataAccess.Refit.Stores;

namespace TournamentTrackerApp.WinformsUI;

public partial class SignupForm : Form
{
    private readonly IUserData _userData;

    public SignupForm(IUserData userData)
    {
        InitializeComponent();
        _userData = userData;
    }

    private void toLoginButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormFactory.CreateLoginForm().Show();

    }

    private async void signupButton_ClickAsync(object sender, EventArgs e)
    {
        User user = new User()
        {
            Email = emailTextBox.Text,
            FirstName = firstnameTextBox.Text,
            LastName = lastnameTextBox.Text,
            Password = passwordTextBox.Text
        };

        var result = await _userData.Register(user);
        if (result.FirstName is not null)
        {
            this.Hide();
            string token = await _userData.Login(user.Email, user.Password);

            token = token.Substring(1, token.Length - 2);


            TokenStore.AccessToken = token;
            MessageBox.Show(token);
            FormFactory.CreateHomeForm().Show();
        }

    }
}

namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class MatchForm : Form
{
    public MatchForm()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void matchSubmitButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new MatchForm().ShowDialog();
    }
}

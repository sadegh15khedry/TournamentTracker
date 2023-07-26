namespace TournamentTrackerApp.WinformsUI.Forms;

public partial class Match : Form
{
    public Match()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void matchSubmitButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new Match().ShowDialog();
    }
}

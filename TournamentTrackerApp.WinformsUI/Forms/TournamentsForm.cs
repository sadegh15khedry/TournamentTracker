using TrackerLibrary;
using UI.DataAccess.Refit.InterFaces;

namespace TournamentTrackerApp.WinformsUI;

public partial class TournamentsForm : Form
{

    private readonly ITournamentData _data;
    public List<Tournament> TournamentList { get; set; }

    public TournamentsForm(ITournamentData data)
    {
        InitializeComponent();
        _data = data;
        TournamentList = _data.GetAll().Result;
        //MessageBox.Show(_data.GetAll().Result.First().Name);
    }


    private void goToAddTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new AddTournamentForm().ShowDialog();
    }

    private void goToTournamentButton_Click(object sender, EventArgs e)
    {
        this.Hide();
        new TournamentTeamSelectionForm().ShowDialog();
    }

    private void Tournaments_Load(object sender, EventArgs e)
    {
        foreach (Tournament tournament in TournamentList)
            tournamentsComboBox.Items.Add(tournament.Name.ToString());
    }
}

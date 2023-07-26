using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITeamData
{
    [Get("/Teams")]
    Task<List<Team>> GetTeams();

    [Get("/Team/{id}")]
    Task<Team> GetTeamById(int id);
}

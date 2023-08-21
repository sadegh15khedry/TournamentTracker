using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

//[Headers("Authorization: Bearer")]
public interface ITeamData
{
    [Get("/Teams")]
    Task<List<Team>> GetAll();

    [Get("/Teams/{id}")]
    Task<Team> GetById(int id);

    [Post("/Teams")]
    Task<Team> Insert(Team team);

    [Put("/Teams")]
    Task<Team> Update(Team team);

    [Delete("/Teams/{id}")]
    Task<Team> Delete(int id);





}

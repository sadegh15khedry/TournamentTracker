using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITeamData
{
    [Get("/Teams")]
    Task<List<Team>> GetAll();

    [Get("/Team/{id}")]
    Task<Team> GetById(int id);

    [Post("/Teams")]
    Task<ActionResult> Insert(Team team);

    [Put("/Teams")]
    Task<ActionResult> Put(Team team);

    [Delete("/Teams/{id}")]
    Task<ActionResult> Delete(int id);



    [Post("/Teams/JoinedTournament")]
    Task<ActionResult> JoinedTournament(int teamId, int tournamentId);

    [Post("/Teams/LeftTournament")]
    Task<ActionResult> LeftTournament(int teamId, int tournamentId);

}

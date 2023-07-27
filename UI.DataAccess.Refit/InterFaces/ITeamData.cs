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

    // POST api/Teams
    [Post("/Teams")]
    public Task<ActionResult> Insert(Team team);

    // PUT api/Team/5
    [Put("/Teams")]
    public Task<ActionResult> Put(Team team);

    // DELETE api/Team/5
    [Delete("/Teams/{id}")]
    public Task<ActionResult> Delete(int id);



    [Post("/Teams/JoinedTournament")]
    public Task<ActionResult> JoinedTournament(int teamId, int tournamentId);

    [Post("/Teams/LeftTournament")]
    public Task<ActionResult> LeftTournament(int teamId, int tournamentId);

}

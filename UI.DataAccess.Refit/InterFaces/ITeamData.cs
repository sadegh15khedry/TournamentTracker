using DataModels;
using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITeamData
{
    [Get("/Teams")]
    Task<List<Team>> GetAll();

    [Get("/Teams/{id}")]
    Task<Team> GetById(int id);

    [Post("/Teams")]
    Task<Team> Insert(Team team);

    [Put("/Teams")]
    Task<ActionResult> Put(Team team);

    [Delete("/Teams/{id}")]
    Task<ActionResult> Delete(int id);



    [Post("/Teams/JoinedTournament")]
    Task<string> JoinedTournament([Body] TournamentTeam tournamentTeam);

    [Post("/Teams/LeftTournament")]
    Task<string> LeftTournament([Body] TournamentTeam tournamentTeam);

}

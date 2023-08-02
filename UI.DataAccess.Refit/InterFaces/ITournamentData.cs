using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITournamentData
{

    [Get("/Tournaments")]
    Task<List<Tournament>> GetAll();

    [Get("/Tournaments/GetTournamentTeams/{tournamentId}")]
    Task<List<Team>> GetTournamentTeams(int tournamentId);
    [Get("/Tournaments/GetTeamsNotInTournament/{tournamentId}")]
    Task<List<Team>> GetTeamsNotInTournament(int tournamentId);

    [Get("/Tournaments/{id}")]
    Task<Tournament> GetById(int id);

    [Post("/Tournaments")]
    Task<ActionResult> Create(Tournament tournament);

    [Put("/Tournaments")]
    Task<ActionResult> Update(Tournament tournament);

    [Delete("/Tournaments")]
    Task<ActionResult> Delete(int id);

    [Post("/Tournaments/SetToFinished/{id}")]
    Task<ActionResult> SetToFinished(int id);

}

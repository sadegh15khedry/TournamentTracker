using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Models;

namespace TournamentTracker.WebAPI.Controllers;
[Produces("application/json")]
[Route("api/[Controller]/")]
[ApiController]
public class TournamentsController : Controller
{
    private readonly ITournamentData _db;

    public TournamentsController(ITournamentData db)
    {
        _db = db;
    }


    [HttpGet]
    // GET: TournamentController
    public async Task<ActionResult> GetAll()
    {
        return Ok(_db.GetAll().Result);
    }


    [Route("/api/[Controller]/{id}")]
    [HttpGet]
    // GET: TournamentController/5
    public ActionResult GetById(int id)
    {
        Tournament tournament = _db.GetById(id).Result;
        tournament.Teams = _db.GetTournamentTeams(id).Result.ToList();
        //tournament.Series = _db.GetTournamentSeries(id).Result.ToList();



        /*        if (tournament == null)
                {
                    return StatusCode((int)HttpStatusCode.NotFound, "Tournament not Found");
                }
                if (teams is null)
                {
                    return StatusCode((int)HttpStatusCode.OK, tournament);
                }
                tournament.Teams = teams;
                if (series is null)
                {
                    return StatusCode((int)HttpStatusCode.NotFound, "Tournament not Found");
                }
                tournament.Series = series;*/
        return StatusCode((int)HttpStatusCode.OK, tournament);


    }


    // POST: TournamentController/Create
    [HttpPost]
    public ActionResult Create(Tournament tournament)
    {
        _db.Insert(tournament);
        return StatusCode((int)HttpStatusCode.Created, "Added");
    }


    [HttpPut]
    // POST: TournamentController/Edit/5
    public ActionResult Update(Tournament tournament)
    {
        _db.Update(tournament);
        return StatusCode((int)HttpStatusCode.OK, "Updated");
    }


    // POST: TournamentController/Delete/5
    [HttpDelete]
    public ActionResult Delete(int id)
    {
        try
        {
            _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, "Deleted");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }


    /// <summary>
    /// Sets a Tournament's isFinished property to True
    /// </summary>
    /// <param name="id">
    /// id of the Tournament
    /// </param>
    /// <remarks>
    ///     sample request : /api/Tournaments/spTournament_SetToFinished/id
    /// </remarks>
    /// 
    /// <returns>
    ///     <Respose code="200">
    ///         Tournament has been set to finished
    ///     </Respose>
    ///     <Respose code="404">
    ///         Tournament Not Found
    ///     </Respose>
    /// </returns>
    [Route("/api/[Controller]/[Action]/{id}")]
    [HttpPost]
    public ActionResult spTournament_SetToFinished(int id)
    {
        _db.SetToFinished(id);
        return StatusCode((int)HttpStatusCode.OK, "Finished");
    }


    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    [HttpGet]
    public async Task<ActionResult> GetTournamentTeams(int tournamentId)
    {
        return Ok(_db.GetTournamentTeams(tournamentId).Result);

    }


    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    [HttpGet]
    public async Task<ActionResult> GetTeamsNotInTournament(int tournamentId)
    {
        return Ok(_db.GetTeamsNotInTournament(tournamentId).Result);
    }

}

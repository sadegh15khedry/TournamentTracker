using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Logic;
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
    // GET: Tournaments
    public async Task<ActionResult<IEnumerable<Tournament>>> GetAll()
    {
        var result = await _db.GetAll();
        return StatusCode((int)HttpStatusCode.OK, result);

    }


    [Route("/api/[Controller]/{id}")]
    [HttpGet]
    // GET: Tournaments/5
    public async Task<ActionResult<Tournament>> GetById(int id)
    {
        var tournament = await _db.GetById(id);
        //var teams = await _db.GetTournamentTeams(id);
        //tournament.Teams = teams.ToList();

        return StatusCode((int)HttpStatusCode.OK, tournament);


    }


    // POST: Tournaments/Create
    [HttpPost]
    public async Task<ActionResult<Tournament>> Create(Tournament tournament)
    {
        var result = await _db.Insert(tournament);
        return StatusCode((int)HttpStatusCode.Created, result);
    }


    [HttpPut]
    // POST: Tournaments/Edit/5
    public async Task<ActionResult<Tournament>> Update(Tournament tournament)
    {
        var result = await _db.Update(tournament);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpDelete]
    // POST: Tournaments/Delete/5
    public async Task<ActionResult<Tournament>> Delete(int id)
    {
        try
        {
            var result = await _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, result);
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
/*    [Route("/api/[Controller]/[Action]/{id}")]
    [HttpPost]
    public async Task<ActionResult<Tournament>> SetToFinished(int id)
    {
        var result = await _db.SetToFinished(id);
        return StatusCode((int)HttpStatusCode.OK, result);
    }*/


    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetTournamentTeams(int tournamentId)
    {
        var result = await _db.GetTournamentTeams(tournamentId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }


    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetTeamsNotInTournament(int tournamentId)
    {
        var teams = await _db.GetTeamsNotInTournament(tournamentId);
        return StatusCode((int)HttpStatusCode.OK, teams);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> AddTeamToTournament([FromBody] TournamentTeam tournamentTeam)
    {
        var tournament = await _db.GetById(tournamentTeam.TournamentId);

        if (tournament.IsStarted == true || tournament.IsFinished == true)
        {
            return StatusCode((int)HttpStatusCode.Created,
                "Tournament is either Started or Finished," +
                " adding or removing team from this tournament is not allowed");
        }

        var result = await _db.AddTeamToTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> RemoveTeamFromTournament([FromBody] TournamentTeam tournamentTeam)
    {
        var tournament = await _db.GetById(tournamentTeam.TournamentId);

        if (tournament.IsStarted == true || tournament.IsFinished == true)
        {
            return StatusCode((int)HttpStatusCode.Created,
                "Tournament is either Started or Finished," +
                " adding or removing team from this tournament is not allowed");
        }

        var result = await _db.RemoveTeamFromTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    // Get : api/Tournaments/GenerateSeries/1
    public async Task<ActionResult> SetToStarted(int tournamentId)
    {
        //var result = await _db.SetToStarted(tournamentId);
        var tournament = await _db.GetById(tournamentId);
        if (TournamentLogic.IsTournamentNumberOfTeamsValid(tournament) == false ||
            tournament.IsStarted == true)
        {
            return StatusCode((int)HttpStatusCode.BadRequest, false);
        }

        var result = await _db.SetToStarted(tournamentId);
        return StatusCode((int)HttpStatusCode.OK, true);

        //return RedirectToAction("MultiInsert", "Series", new { seriesList });
    }

    [HttpGet]
    [Route("/api/Tournaments/CheckIfTournamentEnded/{TournamentId}")]
    public async Task<ActionResult> CheckIfTournamentEnded(int tournamentId)
    {
        var tournament = await _db.GetById(tournamentId);
        if (TournamentLogic.IsTournamentEnded(tournament) == true)
        {
            await _db.SetToFinished(tournamentId);
        }
        return Ok(tournament);
    }
}

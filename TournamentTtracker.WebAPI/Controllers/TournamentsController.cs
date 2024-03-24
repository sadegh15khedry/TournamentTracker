using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

namespace TournamentTracker.WebAPI.Controllers;
[Produces("application/json")]
[Route("api/[Controller]/")]
[ApiController]
[Authorize]
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
        int userId = GetUserIdByRequest();

        var result = await _db.GetAll(userId);
        return StatusCode((int)HttpStatusCode.OK, result);

    }


    [Route("/api/[Controller]/{id}")]
    [HttpGet]
    // GET: Tournaments/5
    public async Task<ActionResult<Tournament>> GetById(int id)
    {
        int userId = GetUserIdByRequest();

        var tournament = await _db.GetById(id, userId);
        //var teams = await _db.GetTournamentTeams(id);
        //tournament.Teams = teams.ToList();

        return StatusCode((int)HttpStatusCode.OK, tournament);


    }


    // POST: Tournaments/Create
    [HttpPost]
    public async Task<ActionResult<Tournament>> Create(Tournament tournament)
    {
        int userId = GetUserIdByRequest();
        tournament.UserId = userId;
        var result = await _db.Insert(tournament);
        return StatusCode((int)HttpStatusCode.Created, result);
    }


    [HttpPut]
    // POST: Tournaments/Edit/5
    public async Task<ActionResult<Tournament>> Update(Tournament tournament)
    {
        int userId = GetUserIdByRequest();
        tournament.UserId = userId;

        var result = await _db.Update(tournament);
        if (tournament.UserId != userId)
        {
            return BadRequest("Not Allowed");
        }
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpDelete]
    // POST: Tournaments/Delete/5
    public async Task<ActionResult<Tournament>> Delete(int id)
    {
        int userId = GetUserIdByRequest();

        try
        {
            var result = await _db.Delete(id, userId);
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
        int userId = GetUserIdByRequest();
        var result = await _db.GetTournamentTeams(tournamentId, userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }


    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetTeamsNotInTournament(int tournamentId)
    {
        int userId = GetUserIdByRequest();

        var teams = await _db.GetTeamsNotInTournament(tournamentId, userId);
        return StatusCode((int)HttpStatusCode.OK, teams);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> AddTeamToTournament([FromBody] TournamentTeam tournamentTeam)
    {
        int userId = GetUserIdByRequest();

        var tournament = await _db.GetById(tournamentTeam.TournamentId, userId);

        if (tournament.IsStarted == true || tournament.IsFinished == true)
        {
            return StatusCode((int)HttpStatusCode.Created,
                "Tournament is either Started or Finished," +
                " adding or removing team from this tournament is not allowed");
        }

        var result = await _db.AddTeamToTournament(tournamentTeam.TeamId,
            tournamentTeam.TournamentId, userId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> RemoveTeamFromTournament([FromBody] TournamentTeam tournamentTeam)
    {
        int userId = GetUserIdByRequest();

        var tournament = await _db.GetById(tournamentTeam.TournamentId, userId);

        if (tournament.IsStarted == true || tournament.IsFinished == true)
        {
            return StatusCode((int)HttpStatusCode.Created,
                "Tournament is either Started or Finished," +
                " adding or removing team from this tournament is not allowed");
        }

        var result = await _db.RemoveTeamFromTournament(tournamentTeam.TeamId,
            tournamentTeam.TournamentId, userId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]/{tournamentId}")]
    // Get : api/Tournaments/GenerateSeries/1
    public async Task<ActionResult> SetToStarted(int tournamentId)
    {
        int userId = GetUserIdByRequest();

        //var result = await _db.SetToStarted(tournamentId);
        var tournament = await _db.GetById(tournamentId, userId);

        if (TournamentLogic.IsTournamentNumberOfTeamsValid(tournament) == false ||
            tournament.IsStarted == true)
        {
            return StatusCode((int)HttpStatusCode.BadRequest, false);
        }

        var result = await _db.SetToStarted(tournamentId, userId);
        return StatusCode((int)HttpStatusCode.OK, result);

        //return RedirectToAction("MultiInsert", "Series", new { seriesList });
    }

    [HttpGet]
    [Route("/api/Tournaments/CheckIfTournamentEnded/{TournamentId}")]
    public async Task<ActionResult> CheckIfTournamentEnded(int tournamentId)
    {
        int userId = GetUserIdByRequest();
        var tournament = await _db.GetById(tournamentId, userId);
        if (TournamentLogic.IsTournamentEnded(tournament) == true)
        {
            await _db.SetToFinished(tournamentId, userId);
        }
        return Ok(tournament);
    }

    private int GetUserIdByRequest()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        int id = 0;
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        if (identity == null)
        {
            return 0;
        }
        IEnumerable<Claim> claims = identity.Claims;
        id = Int32.Parse(claims.ElementAtOrDefault(2).Value);
        return id;
    }
}

using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeamsController : ControllerBase
{
    private readonly ITeamData _db;

    public TeamsController(ITeamData db)
    {
        _db = db;
    }

    // GET: api/Teams
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetAll()
    {
        var result = await _db.GetAll();
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // GET api/Teams/5
    [HttpGet]
    [Route("/api/[controller]/{id}")]
    public async Task<ActionResult<Team>> GetById(int id)
    {
        var result = await _db.GetById(id);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // POST api/Teams
    [HttpPost]
    public async Task<ActionResult<Team>> Insert(Team team)
    {
        var result = await _db.Insert(team);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpPut]
    // PUT api/Team
    public async Task<ActionResult<Team>> Update(Team team)
    {
        var result = await _db.Update(team);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpDelete("{id}")]
    // DELETE api/Team/5
    public async Task<ActionResult<Team>> Delete(int id)
    {
        try
        {
            var result = await _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, result);

        }
        catch (Exception e)
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
            throw;
        }
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> JoinedTournament([FromBody] TournamentTeam tournamentTeam)
    {
        var result = await _db.JoinedTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<TournamentTeam>> LeftTournament([FromBody] TournamentTeam tournamentTeam)
    {
        var result = await _db.LeftTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, result);
    }
}

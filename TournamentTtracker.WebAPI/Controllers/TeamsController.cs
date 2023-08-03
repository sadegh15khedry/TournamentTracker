using DataAccessLibrary.Data.Interfaces;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;

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
    public ActionResult<IEnumerable<Team>> GetAll()
    {
        return StatusCode((int)HttpStatusCode.OK, _db.GetAll().Result);
    }

    // GET api/Teams/5
    [HttpGet]
    [Route("/api/[controller]/{id}")]
    public ActionResult<Team> GetById(int id)
    {
        return StatusCode((int)HttpStatusCode.OK, _db.GetById(id).Result);
    }

    // POST api/Teams
    [HttpPost]
    public ActionResult<Team> Insert(Team team)
    {

        return Ok(_db.Insert(team).Result);
    }

    // PUT api/Team
    [HttpPut]
    public ActionResult Put(Team team)
    {
        _db.Update(team);
        return StatusCode((int)HttpStatusCode.OK, "Updated");
    }

    // DELETE api/Team/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        try
        {
            _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, "Deleted");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");

            throw;
        }
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public ActionResult JoinedTournament([FromBody] TournamentTeam tournamentTeam)
    {
        _db.JoinedTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, "Joined");
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    public ActionResult LeftTournament([FromBody] TournamentTeam tournamentTeam)
    {
        _db.LeftTournament(tournamentTeam.TeamId, tournamentTeam.TournamentId);
        return StatusCode((int)HttpStatusCode.Created, "Left");
    }
}

using DataAccessLibrary.Data.Interfaces;
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
    [HttpGet("{id}")]
    public ActionResult<Team> GetById(int id)
    {
        return StatusCode((int)HttpStatusCode.OK, _db.GetById(id).Result);
    }

    // POST api/Teams
    [HttpPost]
    public ActionResult Insert(Team team)
    {
        _db.Insert(team);
        return StatusCode((int)HttpStatusCode.Created, "Inserted");
    }

    // PUT api/Team/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, Team team)
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

    [Route("api/[Controller]/[Action]")]
    [HttpPost]
    public ActionResult JoinedTournament(int teamId, int tournamentId)
    {
        _db.JoinedTournament(teamId, tournamentId);
        return StatusCode((int)HttpStatusCode.Created, "Joined");
    }

    [Route("api/[Controller]/[Action]")]
    [HttpPost]
    public ActionResult LeftTournament(int teamId, int tournamentId)
    {
        _db.LeftTournament(teamId, tournamentId);
        return StatusCode((int)HttpStatusCode.Created, "Left");
    }
}

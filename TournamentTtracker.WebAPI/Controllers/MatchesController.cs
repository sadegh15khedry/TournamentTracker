using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MatchesController : ControllerBase
{
    // GET: api/match
    private readonly IMatchData _db;

    public MatchesController(IMatchData db)
    {
        _db = db;
    }


    [HttpGet]
    // GET: api/Matches
    public async Task<ActionResult> GetAll()
    {
        var matches = _db.GetAll().Result;
        return Ok(matches);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Matches/5
    public ActionResult GetById(int id)
    {
        var match = _db.GetById(id).Result;
        return Ok(match);
    }

    // POST: api/Players/Create
    [HttpPost]
    public ActionResult Create([FromBody] Match match)
    {
        try
        {
            _db.Insert(match);
            return StatusCode((int)HttpStatusCode.Created, "added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/TournamentController/Edit/5
    public ActionResult Update(Match match)
    {
        _db.Update(match);
        return StatusCode((int)HttpStatusCode.OK, "Updated");
    }

    // POST: api/Delete/5
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
}

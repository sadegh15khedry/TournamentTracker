using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Logic;
using Match = TournamentTrackerLibrary.Models.Match;

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
    public async Task<ActionResult<IEnumerable<Match>>> GetAll()
    {
        var result = await _db.GetAll();
        return StatusCode((int)HttpStatusCode.OK, result);

    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Matches/5
    public async Task<ActionResult<Match>> GetById(int id)
    {
        var result = await _db.GetById(id);
        return StatusCode((int)HttpStatusCode.OK, result);

        //return Redirect("/api/Tournaments");

    }

    // POST: api/Players/Create
    [HttpPost]
    public async Task<ActionResult<Match>> Create([FromBody] Match match)
    {
        try
        {
            match.Outcome = TournamentLogic.GetMatchOutcome(match);
            var result = await _db.Insert(match);

            return Redirect("/api/Series/CheckIfSeriesEnded/" + match.SeriesId);
            //return StatusCode((int)HttpStatusCode.Created, result);
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/TournamentController/Edit/5
    public async Task<ActionResult<Match>> Update(Match match)
    {
        var result = await _db.Update(match);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // POST: api/Delete/5
    [HttpDelete]
    public async Task<ActionResult<Match>> Delete(int id)
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
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TournamentTrackerLibrary.Logic;
using Match = TournamentTrackerLibrary.Models.Match;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

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
        int userId = GetUserIdByRequest();
        var result = await _db.GetAll(userId);
        return StatusCode((int)HttpStatusCode.OK, result);

    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Matches/5
    public async Task<ActionResult<Match>> GetById(int id)
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetById(id, userId);
        return StatusCode((int)HttpStatusCode.OK, result);

        //return Redirect("/api/Tournaments");

    }

    // POST: api/Players/Create
    [HttpPost]
    public async Task<ActionResult<Match>> Create([FromBody] Match match)
    {
        try
        {
            int userId = GetUserIdByRequest();
            match.UserId = userId;
            match.Outcome = TournamentLogic.GetMatchOutcome(match);
            var result = await _db.Insert(match);
            //return RedirectToAction(actionName: "CheckIfSeriesEnded", controllerName: "Series", new { seriesId = match.SeriesId });
            return Redirect("/Series/CheckIfSeriesEnded/" + match.SeriesId);
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
            int userId = GetUserIdByRequest();
            var result = await _db.Delete(id, userId);
            return StatusCode((int)HttpStatusCode.OK, result);
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
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

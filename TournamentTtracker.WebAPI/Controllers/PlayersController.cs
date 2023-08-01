using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TournamentTracker.WebAPI;

[ApiController]
[Route("api/[Controller]")]
public class PlayersController : Controller
{
    private readonly IPlayerData _db;

    public PlayersController(IPlayerData db)
    {
        _db = db;
    }

    [HttpPost]
    [Route("/[Controller]/[Action]")]
    // POST: api/TournamentController/SignedWithTeam
    public ActionResult SignedWithTeam(int playerId, int teamId)
    {
        _db.SignedWithTeam(playerId, teamId);
        return StatusCode((int)HttpStatusCode.OK, "Signed");
    }

    [HttpPost]
    [Route("/[Controller]/[Action]")]
    // POST: api/TournamentController/CanceledContract
    public ActionResult CanceledContract(int playerId)
    {
        _db.CanceledContract(playerId);
        return StatusCode((int)HttpStatusCode.OK, "Contract Cancelled");
    }

    [HttpGet]
    // GET: api/Players
    public async Task<ActionResult> GetAll()
    {
        var players = _db.GetAll().Result;
        foreach (var player in players)
        {
            if (player.TeamId.HasValue)
            {
                player.Team = _db.GetPlayerTeam(player.TeamId.Value).Result;
            }
        }
        return Ok(players);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]

    // GET: api/Players/5
    public ActionResult GetById(int id)
    {
        var player = _db.GetById(id).Result;
        if (player is null)
        {
            return StatusCode((int)HttpStatusCode.NotFound, "player Not Found");
        }
        player.Team = _db.GetPlayerTeam(player.TeamId.Value).Result;
        return Ok(player);
    }

    // POST: api/Players/Create
    [HttpPost]
    public ActionResult Create([FromBody] Player player)
    {
        try
        {
            _db.Insert(player);
            return StatusCode((int)HttpStatusCode.Created, "added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/TournamentController/Edit/5
    public ActionResult Update(Player player)
    {
        _db.Update(player);
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

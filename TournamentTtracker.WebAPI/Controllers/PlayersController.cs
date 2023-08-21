using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Models;

namespace TournamentTracker.WebAPI;

[ApiController]
[Route("api/[Controller]")]
[Authorize]

public class PlayersController : Controller
{
    private readonly IPlayerData _db;

    public PlayersController(IPlayerData db)
    {
        _db = db;
    }



    [HttpGet]
    // GET: api/Players
    public async Task<ActionResult<Player>> GetAll()
    {
        var players = await _db.GetAll();
        /*        foreach (var player in players)
                {
                    if (player.TeamId.HasValue)
                    {
                        player.Team = await _db.GetPlayerTeam(player.TeamId.Value);
                    }
                }*/

        return StatusCode((int)HttpStatusCode.OK, players);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]

    // GET: api/Players/5
    public async Task<ActionResult<Player>> GetById(int id)
    {
        var player = await _db.GetById(id);

        if (player is null)
        {
            return StatusCode((int)HttpStatusCode.NotFound, "player Not Found");
        }
        /*if (player.TeamId is null)
        {
            return Ok(player);
        }

        player.Team = await _db.GetPlayerTeam(player.TeamId.Value);*/
        return StatusCode((int)HttpStatusCode.OK, player);

    }

    // POST: api/Players/Create
    [HttpPost]
    public async Task<ActionResult<Player>> Create([FromBody] Player player)
    {
        try
        {
            var result = await _db.Insert(player);
            return StatusCode((int)HttpStatusCode.Created, "added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/TournamentController/Edit/5
    public async Task<ActionResult<Player>> Update(Player player)
    {
        var result = await _db.Update(player);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // POST: api/Delete/5
    [HttpDelete]
    public async Task<ActionResult<Player>> Delete(int id)
    {
        try
        {
            var result = await _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, "Deleted");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    // POST: api/TournamentController/SignedWithTeam
    public async Task<ActionResult<Player>> SignedWithTeam(int playerId, int teamId)
    {
        var result = await _db.SignedWithTeam(playerId, teamId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    // POST: api/TournamentController/CanceledContract
    public async Task<ActionResult<Player>> CanceledContract(int playerId)
    {
        var result = await _db.CanceledContract(playerId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpGet]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<IEnumerable<Player>>> GetFreeAgentPlayers()
    {
        var result = await _db.GetFreeAgentPlayers();
        return StatusCode((int)HttpStatusCode.OK, result);

    }

    [HttpGet]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult> GetTeamPlayers(int teamId)
    {
        var result = await _db.GetTeamPlayers(teamId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

}

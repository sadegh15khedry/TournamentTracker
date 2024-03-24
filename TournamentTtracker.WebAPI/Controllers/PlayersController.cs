using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
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
        int userId = GetUserIdByRequest();
        var players = await _db.GetAll(userId);
        foreach (var player in players)
        {
            if (player.TeamId.HasValue)
            {
                player.Team = await _db.GetPlayerTeam(player.TeamId.Value, userId);
            }
        }


        return StatusCode((int)HttpStatusCode.OK, players);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]

    // GET: api/Players/5
    public async Task<ActionResult<Player>> GetById(int id)
    {
        int userId = GetUserIdByRequest();
        var player = await _db.GetById(id, userId);

        if (player is null)
        {
            return StatusCode((int)HttpStatusCode.NotFound, "player Not Found");
        }
        if (player.TeamId is null)
        {
            return Ok(player);
        }

        player.Team = await _db.GetPlayerTeam(player.TeamId.Value, userId);
        return StatusCode((int)HttpStatusCode.OK, player);

    }

    // POST: api/Players/Create
    [HttpPost]
    public async Task<ActionResult<Player>> Create([FromBody] Player player)
    {
        try
        {
            int userId = GetUserIdByRequest();
            player.UserId = userId;
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
        int userId = GetUserIdByRequest();
        player.UserId = userId;
        var result = await _db.Update(player);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // POST: api/Delete/5
    [HttpDelete]
    public async Task<ActionResult<Player>> Delete(int id)
    {
        try
        {
            int userId = GetUserIdByRequest();
            var result = await _db.Delete(id, userId);
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
        int userId = GetUserIdByRequest();
        var result = await _db.SignedWithTeam(playerId, teamId, userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpPost]
    [Route("/api/[Controller]/[Action]")]
    // POST: api/TournamentController/CanceledContract
    public async Task<ActionResult<Player>> CanceledContract(int playerId)
    {
        int userId = GetUserIdByRequest();
        var result = await _db.CanceledContract(playerId, userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpGet]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult<IEnumerable<Player>>> GetFreeAgentPlayers()
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetFreeAgentPlayers(userId);
        return StatusCode((int)HttpStatusCode.OK, result);

    }

    [HttpGet]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult> GetTeamPlayers(int teamId)
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetTeamPlayers(teamId, userId);
        return StatusCode((int)HttpStatusCode.OK, result);
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

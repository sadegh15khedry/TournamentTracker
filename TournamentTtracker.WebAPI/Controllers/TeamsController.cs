using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TournamentTrackerLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

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
        int userId = GetUserIdByRequest();
        var result = await _db.GetAll(userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // GET api/Teams/5
    [HttpGet]
    [Route("/api/[controller]/{id}")]
    public async Task<ActionResult<Team>> GetById(int id)
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetById(id, userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // POST api/Teams
    [HttpPost]
    public async Task<ActionResult<Team>> Insert(Team team)
    {

        int userId = GetUserIdByRequest();
        team.UserId = userId;
        var result = await _db.Insert(team);
        //return StatusCode((int)HttpStatusCode.OK, userId);

        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpPut]
    // PUT api/Team
    public async Task<ActionResult<Team>> Update(Team team)
    {
        int userId = GetUserIdByRequest();
        team.UserId = userId;
        var result = await _db.Update(team);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpDelete("{id}")]
    // DELETE api/Team/5
    public async Task<ActionResult<Team>> Delete(int id)
    {
        try
        {
            int userId = GetUserIdByRequest();
            var result = await _db.Delete(id, userId);
            return StatusCode((int)HttpStatusCode.OK, result);

        }
        catch (Exception e)
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
            throw;
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

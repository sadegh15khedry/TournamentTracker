using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class SeriesController : ControllerBase
{
    private readonly ISeriesData _db;

    public SeriesController(ISeriesData db)
    {
        _db = db;
    }


    [HttpGet]
    // GET: api/Series
    public async Task<ActionResult<IEnumerable<Series>>> GetAll()
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetAll(userId);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Series/5
    public async Task<ActionResult<Series>> GetById(int id)
    {
        int userId = GetUserIdByRequest();
        var result = await _db.GetById(id, userId);
        return StatusCode((int)HttpStatusCode.OK, result);

    }

    [HttpPost]
    // POST: api/Series/Create
    public async Task<ActionResult<Series>> Create([FromBody] Series series)
    {
        try
        {
            var result = await _db.Insert(series);
            return StatusCode((int)HttpStatusCode.Created, result);
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/Series/Edit/5
    public async Task<ActionResult<Series>> Update(Series series)
    {
        var result = await _db.Update(series);
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    // Delete: api/Series/
    [Authorize(Roles = "Admin")]
    [HttpDelete(Name = "DeletePlayer")]
    public async Task<ActionResult<Series>> Delete(int id)
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

    [HttpGet]
    [Route("/api/Series/CheckIfSeriesEnded/{seriesId}")]
    public async Task<ActionResult> CheckIfSeriesEnded(int seriesId)
    {
        int userId = GetUserIdByRequest();
        var series = await _db.GetById(seriesId, userId);

        if (TournamentLogic.IsSeriesEnded(series) == true)
        {
            series.IsSeriesEnded = true;
            await _db.SetToFinished(series.Id, userId);
        }
        return Redirect("/api/Tournaments/CheckIfTournamentEnded/" + series.TournamentId);
        //return series;
    }

    [HttpGet]
    [Route("/api/[Controller]/[Action]")]
    public async Task<ActionResult> MultiInsert(List<Series> seriesList)
    {
        foreach (var series in seriesList)
        {
            await _db.Insert(series);
        }
        return StatusCode((int)HttpStatusCode.OK, "Added");
        return Ok("worked");
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

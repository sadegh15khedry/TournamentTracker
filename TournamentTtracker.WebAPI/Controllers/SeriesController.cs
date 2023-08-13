using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TournamentTracker.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
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
        var result = await _db.GetAll();
        return StatusCode((int)HttpStatusCode.OK, result);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Series/5
    public async Task<ActionResult<Series>> GetById(int id)
    {
        var result = await _db.GetById(id);
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
    [HttpDelete]
    public async Task<ActionResult<Series>> Delete(int id)
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

    [HttpGet]
    [Route("/api/[Controller]/[Action]/{seriesId}")]
    public async Task<ActionResult<Series>> CheckIfSeriesEnded(int seriesId)
    {
        var series = await _db.GetById(seriesId);

        if (TournamentLogic.IsSeriesEnded(series) == true)
        {
            series.IsSeriesEnded = true;
            await _db.SetToFinished(series.Id);
        }
        return series;
    }
}

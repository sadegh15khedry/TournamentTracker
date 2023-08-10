using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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
    public async Task<ActionResult> GetAll()
    {
        var series = _db.GetAll().Result;
        return Ok(series);
    }

    [HttpGet]
    [Route("/api/[Controller]/{id}")]
    // GET: api/Series/5
    public ActionResult GetById(int id)
    {
        var series = _db.GetById(id).Result;
        return Ok(series);
    }

    // POST: api/Series/Create
    [HttpPost]
    public ActionResult Create([FromBody] Series series)
    {
        try
        {
            _db.Insert(series);
            return StatusCode((int)HttpStatusCode.Created, "added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }

    [HttpPut]
    // POST: api/Series/Edit/5
    public ActionResult Update(Series series)
    {
        _db.Update(series);
        return StatusCode((int)HttpStatusCode.OK, "Updated");
    }

    // Delete: api/Series/
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

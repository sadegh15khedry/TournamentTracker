using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;

namespace TournamentTracker.WebAPI.Controllers;

[Route("api/[Controller]/")]
[ApiController]
public class TournamentController : Controller
{
    private readonly IMatchData _db;

    public TournamentController(IMatchData db)
    {
        _db = db;
    }

    [HttpGet]
    // GET: TournamentController
    public async Task<ActionResult> GetAll()
    {
        return Ok(_db.GetAll().Result);
    }

    [Route("/[Controller]/{id}")]
    [HttpGet]
    // GET: TournamentController/5
    public ActionResult GetById(int id)
    {
        return Ok(_db.GetById(id).Result);
    }



    // POST: TournamentController/Create
    [HttpPost]
    public ActionResult Create()
    {
        try
        {
            Match match = new Match()
            {
                Outcome = 1,
                FirstTeamScore = 103,
                SecondTeamScore = 100,
                SeriesId = 2
            };
            _db.Insert(match);
            return StatusCode((int)HttpStatusCode.Created, "Match added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }


    [HttpPut]
    // POST: TournamentController/Edit/5
    public ActionResult Update()
    {
        try
        {
            Match match = new Match()
            {
                Id = 19,
                Outcome = 2,
                FirstTeamScore = 203,
                SecondTeamScore = 210,
                SeriesId = 2
            };
            _db.Update(match);
            return StatusCode((int)HttpStatusCode.OK, "Match Updated");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }


    // POST: TournamentController/Delete/5
    [HttpDelete]
    public ActionResult Delete(int id)
    {
        try
        {
            _db.Delete(id);
            return StatusCode((int)HttpStatusCode.OK, "Match Deleted");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }
}

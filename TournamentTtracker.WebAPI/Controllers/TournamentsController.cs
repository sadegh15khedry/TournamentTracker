using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;

namespace TournamentTracker.WebAPI.Controllers;
[Produces("application/json")]
[Route("api/[Controller]/")]
[ApiController]
public class TournamentsController : Controller
{
    private readonly ITournamentData _db;

    public TournamentsController(ITournamentData db)
    {
        _db = db;
    }

    /// <summary>
    /// Sets a Tournament's isFinished property to True
    /// </summary>
    /// <param name="id">
    /// id of the Tournament
    /// </param>
    /// <remarks>
    ///     sample request : /api/Tournaments/spTournament_SetToFinished/id
    /// </remarks>
    /// 
    /// <returns>
    ///     <Respose code="200">
    ///         Tournament has been set to finished
    ///     </Respose>
    ///     <Respose code="404">
    ///         Tournament Not Found
    ///     </Respose>
    /// </returns>
    [Route("api/[Controller]/[Action]")]
    [HttpPost]
    public ActionResult spTournament_SetToFinished(int id)
    {
        _db.SetToFinished(id);
        return StatusCode((int)HttpStatusCode.OK, "Finished");
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
    public ActionResult Create(Tournament tournament)
    {
        _db.Insert(tournament);
        return StatusCode((int)HttpStatusCode.Created, "Added");
    }


    [HttpPut]
    // POST: TournamentController/Edit/5
    public ActionResult Update(Tournament tournament)
    {
        _db.Update(tournament);
        return StatusCode((int)HttpStatusCode.OK, "Updated");
    }


    // POST: TournamentController/Delete/5
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

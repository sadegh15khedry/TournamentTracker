using DataAccessLibrary.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TrackerLibrary;

namespace TournamentTracker.WebAPI;

[ApiController]
[Route("[Controller]/[Action]")]

public class PlayersController : Controller
{
    private readonly IPlayerData _db;

    public PlayersController(IPlayerData db)
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
    public ActionResult Create(Player player)
    {
        try
        {
            _db.Insert(player);
            return StatusCode((int)HttpStatusCode.Created, "Match added");
        }
        catch
        {
            return StatusCode((int)HttpStatusCode.BadRequest, "did not worked");
        }
    }


    [HttpPut]
    // POST: TournamentController/Edit/5
    public ActionResult Edit(Player player)
    {
        try
        {
            _db.Update(player);
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

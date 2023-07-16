using DataAccessLibrary;
using Microsoft.AspNetCore.Mvc;

namespace TournamentTracker.WebAPI.Controllers;

[Route("/Controller/Action")]
public class PlayersController : Controller
{
    private readonly IPlayerData _db;

    public PlayersController(IPlayerData _db)
    {
        this._db = _db;
    }

    [HttpGet]
    // GET: PlayerController
    public ActionResult Get()
    {
        return Ok(_db.GetPlayers().Result.ToList());
    }

    [Route("/Controller/Action/{id}")]
    [HttpGet]
    // GET: PlayerController/Details/5
    public ActionResult GetById(int id)
    {
        return View();
    }

    /*[HttpPost]
    // GET: PlayerController/Create
    public ActionResult Create()
    {
        return View();
    }*/

    // POST: PlayerController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    /*[HttpPut]
    // GET: PlayerController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }*/

    // POST: PlayerController/Edit/5
    [HttpPut]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    /*// GET: PlayerController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }*/

    // POST: PlayerController/Delete/5
    [HttpDelete]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}

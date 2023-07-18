using DataAccessLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace TournamentTracker.WebAPI.Controllers;

[Route("api/[Controller]/Action")]
[ApiController]
public class TournamentController : Controller
{
    private MatchData _db;

    public TournamentController(MatchData db)
    {
        _db = db;
    }

    [HttpGet]
    // GET: TournamentController
    public async Task<ActionResult> Index()
    {
        return View(_db.GetAll().Result);
    }

    /*    [Route("/Controller/Action/{id}")]
        [HttpGet]
        // GET: TournamentController/5
        public ActionResult Details(int id)
        {
            return View(_db.GetById(id));
        }*/



    // POST: TournamentController/Create
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


    [HttpPut]
    // POST: TournamentController/Edit/5
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


    // POST: TournamentController/Delete/5
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

using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITournamentData
{

    [Get("/Tournaments")]
    public Task<ActionResult> GetAll();

    [Get("/Tournaments/{id}")]
    public Task<ActionResult> GetById(int id);

    [Post("/Tournaments")]
    public Task<ActionResult> Create(Tournament tournament);

    [Put("/Tournaments")]
    public Task<ActionResult> Update(Tournament tournament);

    [Delete("/Tournaments")]
    public Task<ActionResult> Delete(int id);

    [Post("/Tournaments/SetToFinished/{id}")]
    [HttpPost]
    public Task<ActionResult> SetToFinished(int id);

}

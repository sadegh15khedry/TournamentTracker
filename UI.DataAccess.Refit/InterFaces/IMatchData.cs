using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface IMatchData
{
    [Get("/Matches")]
    Task<ActionResult> GetAll();


    [Get("/Matches/{id}")]
    Task<ActionResult> GetById(int id);

    [Post("/Matches")]
    Task<ActionResult> Create([FromBody] Match match);

    [Put("/Matches")]
    Task<ActionResult> Update(Match match);

    [Delete("/Matches")]
    Task<ActionResult> Delete(int id);


}

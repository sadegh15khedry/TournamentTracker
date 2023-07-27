using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ISeriesData
{



    [Get("/Series")]
    // GET: api/Series
    Task<ActionResult> GetAll();

    [Get("/Series/{id}")]
    public ActionResult GetById(int id);


    [Post("/Series")]
    Task<ActionResult> Create([FromBody] Series series);


    [Put("/Series")]
    Task<ActionResult> Update(Series series);


    [Delete("/Series/{id}")]
    Task<ActionResult> Delete(int id);


}

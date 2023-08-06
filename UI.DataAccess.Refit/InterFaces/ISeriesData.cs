using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface ISeriesData
{

    [Get("/Series")]
    // GET: api/Series
    Task<List<Series>> GetAll();

    [Get("/Series/{id}")]
    Task<Series> GetById(int id);


    [Post("/Series")]
    Task<Series> Create([FromBody] Series series);


    [Put("/Series")]
    Task<Series> Update(Series series);


    [Delete("/Series/{id}")]
    Task<string> Delete(int id);


}

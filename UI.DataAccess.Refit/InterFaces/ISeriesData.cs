using Microsoft.AspNetCore.Mvc;
using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

//[Headers("Authorization: Bearer")]
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
    Task<Series> Delete(int id);

    [Get("/Series/CheckIfSeriesEnded/{seriesId}")]
    Task<Series> CheckIfSeriesEnded(int seriesId);

}

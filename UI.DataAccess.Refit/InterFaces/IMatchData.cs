using Microsoft.AspNetCore.Mvc;
using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

//[Headers("Authorization: Bearer")]
public interface IMatchData
{
    [Get("/Matches")]
    Task<List<Match>> GetAll();


    [Get("/Matches/{id}")]
    Task<Match> GetById(int id);

    [Post("/Matches")]
    Task<Match> Create([FromBody] Match match);

    [Put("/Matches")]
    Task<Match> Update(Match match);

    [Delete("/Matches")]
    Task<Match> Delete(int id);


}

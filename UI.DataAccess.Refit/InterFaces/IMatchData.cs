﻿using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

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
    Task<string> Delete(int id);


}

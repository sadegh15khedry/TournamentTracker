using Microsoft.AspNetCore.Mvc;
using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

public interface IUserData
{
    [Get("/Users")]
    Task<List<User>> GetAll();

    [Get("/Users/{id}")]
    Task<User> GetById(int id);

    [Post("/Users/Register")]
    Task<User> Register([FromBody] User user);


    [Post("/Users/Login")]
    Task<string> Login(string userEmail,
        string userPassword);


    [Put("/Users")]
    Task<User> Update(User user);

    [Delete("/Users")]
    Task<User> Delete(int id);


}

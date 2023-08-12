using Microsoft.AspNetCore.Mvc;
using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

public interface IPlayerData
{

    [Post("/Players/SignedWithTeam")]
    Task<Player> SignedWithTeam(int playerId, int teamId);

    [Post("/Players/CanceledContract")]
    Task<Player> CanceledContract(int playerId);

    [Get("/Players")]
    Task<List<Player>> GetAll();

    [Get("/Players/{id}")]
    Task<Player> GetById(int id);

    [Post("/Players")]
    Task<Player> Create([FromBody] Player player);

    [Put("/Players")]
    Task<Player> Update(Player player);

    [Delete("/Players")]
    Task<Player> Delete(int id);

    [Get("/Players/GetFreeAgentPlayers")]
    Task<List<Player>> GetFreeAgentPlayers();


    [Get("/Players/GetTeamPlayers")]
    Task<List<Player>> GetTeamPlayers(int teamId);


}

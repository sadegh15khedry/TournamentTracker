using Microsoft.AspNetCore.Mvc;
using Refit;
using TrackerLibrary;

namespace UI.DataAccess.Refit.InterFaces;

public interface IPlayerData
{

    [Post("/Players/SignedWithTeam")]
    Task<string> SignedWithTeam(int playerId, int teamId);

    [Post("/Players/CanceledContract")]
    Task<string> CanceledContract(int playerId);

    [Get("/Players")]
    Task<List<Player>> GetAll();

    [Get("/Players/{id}")]
    Task<Player> GetById(int id);

    [Post("/Players")]
    Task<Player> Create([FromBody] Player player);

    [Put("/Players")]
    Task<Player> Update(Player player);

    [Delete("/Players")]
    Task<string> Delete(int id);

    [Get("/Players/GetFreeAgentPlayers")]
    Task<List<Player>> GetFreeAgentPlayers();


    [Get("/Players/GetTeamPlayers")]
    Task<List<Player>> GetTeamPlayers(int teamId);


}

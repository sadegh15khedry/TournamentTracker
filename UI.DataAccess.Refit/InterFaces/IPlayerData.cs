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

    [HttpGet("/Players")]
    Task<ActionResult> GetAll();

    [Get("/Players/{id}")]
    Task<ActionResult> GetById(int id);

    [Post("/Players")]
    Task<ActionResult> Create([FromBody] Player player);

    [Put("/Players")]
    Task<ActionResult> Update(Player player);

    [Delete("/Players")]
    Task<ActionResult> Delete(int id);

    [Get("/Players/GetFreeAgentPlayers")]
    Task<List<Player>> GetFreeAgentPlayers();


    [Get("/Players/GetTeamPlayers")]
    Task<List<Player>> GetTeamPlayers(int teamId);


}

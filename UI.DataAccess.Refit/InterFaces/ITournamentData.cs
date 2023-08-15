using Refit;
using TournamentTrackerLibrary.Models;

namespace UI.DataAccess.Refit.InterFaces;

public interface ITournamentData
{

    [Get("/Tournaments")]
    Task<List<Tournament>> GetAll();

    [Get("/Tournaments/GetTournamentTeams/{tournamentId}")]
    Task<List<Team>> GetTournamentTeams(int tournamentId);

    [Get("/Tournaments/GetTeamsNotInTournament/{tournamentId}")]
    Task<List<Team>> GetTeamsNotInTournament(int tournamentId);

    [Get("/Tournaments/{id}")]
    Task<Tournament> GetById(int id);

    [Post("/Tournaments")]
    Task<Tournament> Create(Tournament tournament);

    [Put("/Tournaments")]
    Task<Tournament> Update(Tournament tournament);

    [Delete("/Tournaments")]
    Task<Tournament> Delete(int id);

    /*    [Post("/Tournaments/SetToFinished/{id}")]
        Task<Tournament> SetToFinished(int id);*/

    [Post("/Tournaments/AddTeamToTournament")]
    Task<TournamentTeam> AddTeamToTournament([Body] TournamentTeam tournamentTeam);

    [Post("/Tournaments/RemoveTeamFromTournament")]
    Task<TournamentTeam> RemoveTeamFromTournament([Body] TournamentTeam tournamentTeam);

    //[Post("/Tournaments/GenerateSeries/{tournamentId}")]
    //Task<List<Series>> GenerateSeries(int tournamentId);

    [Post("/Tournaments/SetToStarted/{tournamentId}")]
    Task<bool> SetToStarted(int tournamentId);


}

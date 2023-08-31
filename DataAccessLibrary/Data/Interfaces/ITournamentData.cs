
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITournamentData
    {
        ISqlDataAccess _db { get; }

        Task<Tournament> Delete(int id, int userId);
        Task<IEnumerable<Tournament>> GetAll(int userId);
        Task<IEnumerable<Team>> GetTournamentTeams(int tournamentId, int userId);
        Task<IEnumerable<Team>> GetTeamsNotInTournament(int tournamentId, int userId);
        Task<Tournament> GetById(int id, int userId);
        Task<Tournament> Insert(Tournament tournament);
        Task<Tournament> SetToFinished(int id, int userId);
        Task<Tournament> Update(Tournament tournament);
        //Task<IEnumerable<Series>> GetTournamentSeries(int tournamentId);

        Task<TournamentTeam> AddTeamToTournament(int teamId, int tournamentId, int userId);
        Task<TournamentTeam> RemoveTeamFromTournament(int teamId, int tournamentId, int userId);
        Task<Tournament> SetToStarted(int id, int userId);
        //Task<Series> InsertSeries(Series series);
    }
}
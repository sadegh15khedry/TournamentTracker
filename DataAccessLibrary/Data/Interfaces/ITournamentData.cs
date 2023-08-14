
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITournamentData
    {
        ISqlDataAccess _db { get; }

        Task<Tournament> Delete(int id);
        Task<IEnumerable<Tournament>> GetAll();
        Task<IEnumerable<Team>> GetTournamentTeams(int tournamentId);
        Task<IEnumerable<Team>> GetTeamsNotInTournament(int tournamentId);
        Task<Tournament> GetById(int id);
        Task<Tournament> Insert(Tournament tournament);
        Task<Tournament> SetToFinished(int id);
        Task<Tournament> Update(Tournament tournament);
        //Task<IEnumerable<Series>> GetTournamentSeries(int tournamentId);

        Task<TournamentTeam> AddTeamToTournament(int teamId, int tournamentId);
        Task<TournamentTeam> RemoveTeamFromTournament(int teamId, int tournamentId);
        Task<Tournament> SetToStarted(int id);
        //Task<Series> InsertSeries(Series series);
    }
}
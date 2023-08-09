using TrackerLibrary;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITournamentData
    {
        ISqlDataAccess _db { get; }

        Task Delete(int id);
        Task<IEnumerable<Tournament>> GetAll();
        Task<IEnumerable<Team>> GetTournamentTeams(int tournamentId);
        Task<IEnumerable<Team>> GetTeamsNotInTournament(int tournamentId);
        Task<Tournament> GetById(int id);
        Task Insert(Tournament tournament);
        Task SetToFinished(int id);
        Task Update(Tournament tournament);
        Task<IEnumerable<Series>> GetTournamentSeries(int tournamentId);
    }
}
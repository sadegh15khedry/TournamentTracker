using TrackerLibrary;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITeamData
    {
        ISqlDataAccess _db { get; }

        Task Delete(int id);
        Task<IEnumerable<Team>> GetAll();
        Task<Team> GetById(int id);
        Task Insert(Team team);
        Task JoinedTournament(int teamId, int tournamentId);
        Task LeftTournament(int teamId, int tournamentId);
        Task Update(Team team);
    }
}
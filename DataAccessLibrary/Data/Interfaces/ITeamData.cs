using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
    public interface ITeamData
    {
        ISqlDataAccess _db { get; }

        Task<Team> Delete(int id);
        Task<IEnumerable<Team>> GetAll();
        Task<Team> GetById(int id);
        Task<Team> Insert(Team team);
        Task<TournamentTeam> JoinedTournament(int teamId, int tournamentId);
        Task<TournamentTeam> LeftTournament(int teamId, int tournamentId);
        Task<Team> Update(Team team);
    }
}
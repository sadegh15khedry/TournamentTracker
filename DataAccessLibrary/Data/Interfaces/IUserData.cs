using DataAccessLibrary;
using TournamentTrackerLibrary.Models;

namespace DataBase.DataAccessLibrary.Dapper.Data.Interfaces
{
    public interface IUserData
    {
        ISqlDataAccess _db { get; }

        Task<User> Delete(int id);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> Insert(User user);
        Task<User> Update(User user);
        Task<bool> DoesEmailExists(string email);
        Task<User> GetByEmail(string email);
    }
}
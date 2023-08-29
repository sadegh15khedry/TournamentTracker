using DataAccessLibrary;
using TournamentTrackerLibrary.Authentication;
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
        Task<RefreshToken> GetRefreshTokenByToken(string token);
        Task<RefreshToken> SetRefreshTokenToNotValidByToken(string token);
        Task<RefreshToken> InsertRefreshToken(RefreshToken refreshToken);
        Task<User> UpdatePassword(int userId, string password);
    }
}
using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
using TournamentTrackerLibrary.Authentication;
using TournamentTrackerLibrary.Models;

namespace DataAccessLibrary;

public class UserData : IUserData
{
    /// <summary>
    /// !imporatant
    ///
    /// </summary>
    public ISqlDataAccess _db { get; }

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }


    public async Task<IEnumerable<User>> GetAll()
    {
        var result = await _db.LoadData<User, dynamic>("dbo.spUser_GetAll", new { });
        return result;
    }

    public async Task<User> GetById(int id)
    {
        var results = await _db.LoadData<User, dynamic>("dbo.spUser_GetByID", new { Id = id });

        return results.FirstOrDefault();
    }

    public async Task<User> Insert(User user)
    {
        var result = await _db.LoadData<User, dynamic>("dbo.spUser_Insert", new
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = user.Password
        });
        return result.FirstOrDefault();

    }

    public async Task<User> Update(User user)
    {
        var result = await _db.LoadData<User, dynamic>("dbo.spUser_Update", new
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            EmailVerificationCode = user.EmailVerificationCode,
            EmailVerificationCodeExpirationDate = user.EmailVerificationCondeExpirationDate,
            IsEmailVerified = user.IsEmailVerified,
            PhoneNumber = user.PhoneNumber,
            IsPhoneNumberVerified = user.IsPhoneNumberVerified,
            PhoneVerificationCode = user.PhoneVerificationConde,
            PhoneVerificationCodeExpirationDate = user.PhoneVerificationCondeExpirationDate
        });
        return result.FirstOrDefault();


    }

    public async Task<User> Delete(int id)
    {
        var result = await _db.LoadData<User, dynamic>("dbo.spUser_Delete", new { Id = id });
        return result.FirstOrDefault();
    }

    public async Task<RefreshToken> GetRefreshTokenByToken(string token)
    {
        var results = await _db.LoadData<RefreshToken, dynamic>
            ("dbo.spRefreshToken_GetByToken", new { Token = token });

        return results.FirstOrDefault();
    }
    public async Task<RefreshToken> SetRefreshTokenToNotValidByToken(string token)
    {
        var results = await _db.LoadData<RefreshToken, dynamic>
            ("dbo.spRefreshToken_SetToNotValidByToken", new { Token = token });

        return results.FirstOrDefault();
    }

    public async Task<RefreshToken> InsertRefreshToken(RefreshToken refreshToken)
    {
        var results = await _db.LoadData<RefreshToken, dynamic>
            ("dbo.spRefreshToken_Insert", new
            {
                Token = refreshToken.Token,
                UserId = refreshToken.UserId,
                ExpireDate = refreshToken.ExpireDate,
                CreateDate = refreshToken.CreateDate
            });

        return results.FirstOrDefault();
    }



    public async Task<bool> DoesEmailExists(string email)
    {
        var results = await _db.LoadData<User, dynamic>("spUser_EmailSearch", new { Email = email });

        if (results.Count() > 0)
        {
            return true;
        }

        return false;
    }

    public async Task<User> GetByEmail(string email)
    {
        var results = await _db.LoadData<User, dynamic>("spUser_GetByEmail", new { Email = email });

        return results.FirstOrDefault();
    }


}

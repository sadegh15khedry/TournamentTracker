﻿using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
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
        });
        return result.FirstOrDefault();


    }

    public async Task<User> Delete(int id)
    {
        var result = await _db.LoadData<User, dynamic>("dbo.spUser_Delete", new { Id = id });
        return result.FirstOrDefault();
    }




}

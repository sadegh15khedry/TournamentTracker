﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using TournamentTrackerLibrary.Authentication;
using TournamentTrackerLibrary.Models;

namespace TournamentTrackerLibrary.Logic;

public static class TokenHelper
{


    public static string CreateJwtToken(User user, IConfiguration configuration)
    {


        List<Claim> claims = new List<Claim>()
        {
                //new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            configuration.GetSection("Tokens:Key").Value
            ));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
            );
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);



        return jwt;
    }

    public static RefreshToken CreateRefreshToken(User user)
    {
        var refreshToken = new RefreshToken()
        {
            UserId = user.Id,
            Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
            CreateDate = DateTime.Now,
            ExpireDate = DateTime.Now.AddDays(90)
        };
        return refreshToken;
    }


}

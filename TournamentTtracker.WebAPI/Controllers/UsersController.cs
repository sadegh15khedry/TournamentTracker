using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography;
using TournamentTrackerLibrary.Logic;
using TournamentTrackerLibrary.Models;

namespace TournamentTracker.WebAPI.Controllers;

[Produces("application/json")]
[Route("api/[Controller]/")]
[ApiController]
public class UsersController : ControllerBase
{
    private IUserData _db;
    private IConfiguration _configuration;
    //private readonly AuthService _auth;


    public UsersController(IUserData userData, IConfiguration configuration)
    {
        _configuration = configuration;
        //_auth = new AuthService(_configuration);
        _db = userData;
    }

    // GET: api/<UsersController1>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var result = await _db.GetAll();
        return result.ToList();
    }

    // GET api/<UsersController1>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<User>>> GetById(int id)
    {
        var user = await _db.GetById(id);
        if (user == null)
        {
            return NotFound("user not found");
        }
        else
        {
            return Ok(user);
        }
    }


    // PUT api/<UsersController1>/update/5
    [Authorize]
    [HttpPut]
    public async Task<ActionResult<User>> Update([FromForm] User user)
    {
        if (user == null)
        {
            return BadRequest("user object is null");
        }

        var result = await _db.Update(user);
        return result;
    }

    // DELETE api/<UsersController1>/5
    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _db.Delete(id);
        return StatusCode((int)HttpStatusCode.OK, result);
    }


    // POST api/<UsersController1>/register
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<IActionResult> RegisterUser(User user)
    {
        //ckecking email and username to see if already exists
        bool isEmailExists = await _db.DoesEmailExists(user.Email);
        if (isEmailExists == true)
        {
            return BadRequest("a user with this email already exists");
        }

        //UserValidator validations = new UserValidator();
        //var results = validations.Validate(user);

        /*        if (results.IsValid == true)
                {
                    string validationErrorsMessage = "";
                    foreach (var failure in results.Errors)
                    {
                        validationErrorsMessage += "Property " + failure.PropertyName
                            + " failed validation. Error was: " + failure.ErrorMessage + "\n";
                    }
                    return BadRequest(validationErrorsMessage);
                }*/
        user.Password = SecretHasher.Hash(user.Password);
        //var isValid = hashing.Verify("test", hash);

        user.Role = "user";

        var result = await _db.Insert(user);
        return Ok(user.Password);
    }


    // POST api/<UsersController1>/login
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult<User>> LoginUser(string userEmail, string userPassword)
    {
        var user = await _db.GetByEmail(userEmail);
        if (user == null)
        {
            return NotFound("user not found");
        }

        //var hashing =  CreatePasswordHash();
        var isValid = SecretHasher.Verify(userPassword, user.Password);
        if (isValid == false)
        {
            return Unauthorized("wrong password");
        }
        string token = TokenHelper.CreateToken(user, _configuration);
        return StatusCode((int)HttpStatusCode.OK, token);
        //return StatusCode((int)HttpStatusCode.OK, user);


        /*var claims = new[]
        {
                new Claim(JwtRegisteredClaimNames.Email, myUser.UserEmail),
                new Claim(ClaimTypes.Email, myUser.UserEmail),
                new Claim(ClaimTypes.Role, myUser.UserRole),
                new Claim(ClaimTypes.NameIdentifier, myUser.UserId.ToString()),
        };

        var token = _auth.GenerateAccessToken(claims);
        return new ObjectResult(new
        {
            access_token = token.AccessToken,
            expires_in = token.ExpiresIn,
            token_type = token.TokenType,
            creation_Time = token.ValidFrom,
            expiration_Time = token.ValidTo,
            user_id = myUser.UserId,
            user_role = myUser.UserRole,
        });*/

    }
    public static void CreatePasswordHash(string password, out byte[] passwordHash,
        out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash,
        byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {

            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computedHash.SequenceEqual(passwordHash);
        }
    }



}

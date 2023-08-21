using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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


    public UsersController(IUserData userData, IConfiguration configuration)
    {
        _configuration = configuration;
        _db = userData;
    }

    // GET: api/<UsersController1>
    [HttpGet]
    [Authorize]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var result = await _db.GetAll();
        return result.ToList();
    }

    // GET api/<UsersController1>/5
    [HttpGet("{id}")]
    [Authorize]
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
    [HttpPut]
    [Authorize]
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
    public async Task<IActionResult> Register(User user)
    {
        //ckecking email and username to see if already exists
        bool isEmailExists = await _db.DoesEmailExists(user.Email);
        if (isEmailExists == true)
        {
            return BadRequest("a user with this email already exists");
        }
        user.Password = SecretHasher.Hash(user.Password);
        user.Role = "user";

        var result = await _db.Insert(user);
        return StatusCode((int)HttpStatusCode.Created, result);
    }


    // POST api/<UsersController1>/login
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult<User>> Login(string userEmail,
         string userPassword)
    {
        var user = await _db.GetByEmail(userEmail);
        if (user == null)
        {
            return NotFound("user not found");
        }

        var isValid = SecretHasher.Verify(userPassword, user.Password);
        if (isValid == false)
        {
            return Unauthorized("wrong password");
        }
        string token = TokenHelper.CreateToken(user, _configuration);
        return StatusCode((int)HttpStatusCode.OK, token);
    }


}

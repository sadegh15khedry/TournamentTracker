using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using TournamentTrackerLibrary.Authentication;
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
    public async Task<ActionResult<User>> ConfirmEmail(int userId, string activationToken)
    {
        var user = await _db.
            GetById(userId);
        if (user == null)
        {
            return NotFound("user not found");
        }
        return Ok
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
        if (user.IsEmailVerified == false)
        {
            var result = SendVerificationEmail(user);

            return Ok("verification Email has been send to you." +
                " please verify your Email to continue." + "   " + result);
        }
        string jwtToken = TokenHelper.CreateJwtToken(user, _configuration);
        RefreshToken refreshToken = TokenHelper.CreateRefreshToken(user);
        await _db.InsertRefreshToken(refreshToken);
        SetRefreshToken(refreshToken);
        return StatusCode((int)HttpStatusCode.OK, jwtToken);
    }

    private string SendVerificationEmail(User user)
    {
        var emailBody = "please confirm your email Address <a href=\"#Url#\">Click Here</a> ";
        string ActivationToken = Guid.NewGuid().ToString();
        var callbackUrl = Request.Scheme + "://" + Request.Host + Url.Action("ConfirmEmail",
            "Users", new { userId = user.Id, activationToken = ActivationToken });
        emailBody.Replace("#Url#", callbackUrl);

        return emailBody;

        //var expirationDate = DateTime.Now.AddMinutes(2);

    }

    [Authorize]
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult<string>> RefreshJwtToken()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        int id = 0;
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        if (identity != null)
        {
            IEnumerable<Claim> claims = identity.Claims;
            id = Int32.Parse(claims.ElementAtOrDefault(2).Value);

        }


        var storedRefreshToken = await _db.GetRefreshTokenByToken(refreshToken);
        if (storedRefreshToken == null)
        {
            await _db.SetRefreshTokenToNotValidByToken(refreshToken);
            return BadRequest("Sorry please Login");
        }
        if (storedRefreshToken.UserId != id)
        {
            await _db.SetRefreshTokenToNotValidByToken(refreshToken);
            return BadRequest("Sorry please Login");
        }
        if (storedRefreshToken.ExpireDate < DateTime.Now)
        {
            await _db.SetRefreshTokenToNotValidByToken(refreshToken);
            return BadRequest("Sorry please Login");
        }
        // should get id from claim and verify the tokens
        User user = await _db.GetById(id);
        string jwtToken = TokenHelper.CreateJwtToken(user, _configuration);
        return StatusCode((int)HttpStatusCode.OK, jwtToken);
    }
    private void SetRefreshToken(RefreshToken refreshToken)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = refreshToken.ExpireDate
        };
        Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
    }

}

using DataBase.DataAccessLibrary.Dapper.Data.Interfaces;
using EmailHelperLibrary;
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
        //return Ok(user.Password.Length);
        user.Password = SecretHasher.Hash(user.Password);
        user.Role = "user";

        var result = await _db.Insert(user);
        return StatusCode((int)HttpStatusCode.Created, result);
    }


    // POST api/<UsersController1>/ConfirmEmail
    [Route("/api/[Controller]/[Action]")]
    [HttpGet]
    public async Task<ActionResult<User>> ConfirmEmail([FromQuery] int userId,
        [FromQuery] string activationToken)
    {
        var user = await _db.GetById(userId);
        if (user == null)
        {
            return NotFound("user not found");
        }
        if (user.EmailVerificationCode != activationToken)
        {
            return BadRequest("something is not right");
        }
        if (user.EmailVerificationCondeExpirationDate < DateTime.Now)
        {
            return BadRequest("please try again");
        }
        user.IsEmailVerified = true;
        await _db.Update(user);
        return Ok("confirmed");
    }


    // POST api/<UsersController1>/login
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult<string>> Login(string userEmail,
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
        /*if (user.IsEmailVerified == false)
        {
            var result = await SendVerificationEmailAsync(user);

            return Ok(result);
        }*/

        string jwtToken = TokenHelper.CreateJwtToken(user, _configuration);
        RefreshToken refreshToken = TokenHelper.CreateRefreshToken(user);
        await _db.InsertRefreshToken(refreshToken);
        SetRefreshToken(refreshToken);
        return StatusCode((int)HttpStatusCode.OK, jwtToken);
    }

    private async Task<string> SendVerificationEmailAsync(User user)
    {
        var emailBody = "please confirm your email Address <a href=\"#Url#\">Click Here</a> ";
        string ActivationToken = System.Text.Encodings.Web.HtmlEncoder.Default
            .Encode(Guid.NewGuid().ToString());

        ActivationToken = ActivationToken.Replace("-", "");

        var callbackUrl = Request.Scheme + "://" + Request.Host + Url.Action("ConfirmEmail",
            "Users", new { userId = user.Id, activationToken = ActivationToken });
        user.EmailVerificationCode = ActivationToken;
        user.EmailVerificationCondeExpirationDate = DateTime.Now.AddMinutes(2);

        await _db.Update(user);

        emailBody = emailBody.Replace("#Url#", callbackUrl);

        await EmailHelper.SendEmailAsync("test@test.com", user.Email, "Email Verification" +
            " Link", emailBody);

        return emailBody;

        //var expirationDate = DateTime.Now.AddMinutes(2);

    }
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult> UpdatePassword([FromForm] int userId,
        [FromForm] string forgotPasswordToken, [FromForm] string newPassword)
    {
        var user = await _db.GetById(userId);
        if (user == null)
        {
            return NotFound();
        }
        if (user.EmailVerificationCode != forgotPasswordToken)
        {
            return BadRequest();
        }
        //return Ok(user.Password.Length + user.Password);
        user.Password = SecretHasher.Hash(newPassword);
        var result = await _db.UpdatePassword(user.Id, user.Password);

        return Ok(result);

        //return Ok(newPassword + "\n" + user.Password);
    }

    [Route("/api/[Controller]/[Action]")]
    [HttpGet]
    public async Task<ContentResult> RestPassword(int userId, string forgotPasswordToken)
    {
        var user = await _db.GetById(userId);
        string response = string.Empty;
        if (user == null)
        {
            response = "not Found";
        }
        else if (user.EmailVerificationCode != forgotPasswordToken)
        {
            response = forgotPasswordToken + "\n" + user.EmailVerificationCode;
        }
        else
        {
            var postUrl = Request.Scheme + "://" + Request.Host + Url.Action("UpdatePassword",
            "Users", new { userId = user.Id, forgotPasswordToken = forgotPasswordToken });

            response = "<form method=\"Post\" Action=\" " + postUrl + "\" >" +
                                "<input name=\"newPassword\"  type=\"password\" />" +
                "<input name=\"userId\" value=" + userId + " type=\"hidden\" />" +
                                "<input name=\"forgotPasswordToken\" value=" + forgotPasswordToken + " type=\"hidden\" />" +
                                "<input type=\"submit\" />" +

                "</form>";

        }
        return new ContentResult
        {
            ContentType = "text/html",
            Content = response
        };

    }

    // POST api/<UsersController1>/login
    [Route("/api/[Controller]/[Action]")]
    [HttpPost]
    public async Task<ActionResult> ForgotPassword(string email)
    {
        var user = await _db.GetByEmail(email);
        if (user == null)
        {
            return NotFound();
        }
        var emailBody = "please fallow the link to rest your password.<a href=\"#Url#\">Click Here</a> ";
        string forgotPasswordToken = System.Text.Encodings.Web.HtmlEncoder.Default
            .Encode(Guid.NewGuid().ToString());

        forgotPasswordToken = forgotPasswordToken.Replace("-", "");

        user.EmailVerificationCode = forgotPasswordToken;
        user.EmailVerificationCondeExpirationDate = DateTime.Now.AddMinutes(2);

        await _db.Update(user);

        var callbackUrl = Request.Scheme + "://" + Request.Host + Url.Action("RestPassword",
            "Users", new { userId = user.Id, forgotPasswordToken = forgotPasswordToken });
        emailBody = emailBody.Replace("#Url#", callbackUrl);

        return Ok(emailBody);

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

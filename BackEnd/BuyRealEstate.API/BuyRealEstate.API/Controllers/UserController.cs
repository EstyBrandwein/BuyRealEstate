using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    //[HttpPost("login")]
    //public async Task<IActionResult> LoginAndSendVerification([FromBody] LoginDTO request)
    //{
    //    if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
    //    {
    //        return BadRequest("Username and password are required.");
    //    }

    //    // בדיקת פרטי משתמש
    //    var user = await _userService.LoginAsync(request.Username, request.Password);
    //    if (user == null)
    //    {
    //        return Unauthorized("Invalid username or password.");
    //    }

    //    // יצירת קוד אימות ושליחתו למייל
    //    var verificationCode = await _authService.GenerateVerificationCodeAsync(user.ID);
    //    await _authService.SendVerificationEmail(user.Email, verificationCode);

    //    return Ok(new { Message = "Verification code sent to email.", UserId = user.ID });
    //}

    //[HttpPost("verify")]
    //public async Task<IActionResult> VerifyCode([FromBody] VerificationRequest request)
    //{
    //    if (request == null || string.IsNullOrEmpty(request.Code))
    //    {
    //        return BadRequest("Verification code is required.");
    //    }

    //    var isValid = await _authService.VerifyCodeAsync(request.UserId, request.Code);
    //    if (!isValid)
    //    {
    //        return Unauthorized("Invalid or expired verification code.");
    //    }

    //    return Ok(new { Message = "Verification successful, you can now log in." });
    //}





    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
    {
        var isValidUser = await _userService.LoginAsync(loginDto.Username, loginDto.Password);
        if (!isValidUser) return Unauthorized();

        return Ok("Login successful.");
    }



    [HttpGet("{id}")]
    public async Task<ActionResult<UsersDTO>> Get(int id)
    {
        var user = await _userService.GetAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UsersDTO>>> GetAll()
    {
        var users = await _userService.GetAllAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] UsersDTO userDto)
    {
        if (userDto == null)
        {
            return BadRequest("User data is required.");
        }
        await _userService.AddAsync(userDto);
        return CreatedAtAction(nameof(Get), new { id = userDto.ID }, userDto);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UsersDTO userDto)
    {
        if (userDto == null )
        {
            return BadRequest("User data is invalid.");
        }

        await _userService.UpdateAsync(id, userDto);
        return NoContent();
    }


     
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _userService.DeleteAsync(id);
        return NoContent();
    }

}

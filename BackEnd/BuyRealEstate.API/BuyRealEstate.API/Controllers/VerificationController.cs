using BuyRealEstate.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;
using System.Security.Claims;

[Route("api/[controller]")]
[ApiController]
public class VerificationController : ControllerBase
{
    private readonly IEmailService _emailService;
    private readonly IUserService _userervice;

    public VerificationController(IEmailService emailService, IUserService userService)
    {
        _emailService = emailService;
        _userervice = userService;
    }

    [HttpPost]
    public async Task<IActionResult> SendVerificationCode([FromBody] VerificationRequest verificationRequest)
    {
        if (verificationRequest == null || string.IsNullOrEmpty(verificationRequest.Username) || string.IsNullOrEmpty(verificationRequest.Password))
        {
            return BadRequest("Username and password are required.");
        }

        // Here, validate the user credentials with your DB (e.g. using _userRepository)
        var user = await _userervice.GetUserAsync(verificationRequest.Username);

        if (user == null || !BCrypt.Net.BCrypt.Verify(verificationRequest.Password, user.Password))
        {
            return Unauthorized("Invalid username or password.");
        }

        // Generate a random verification code
        var verificationCode = new Random().Next(100000, 999999).ToString();

        // Save the verification code to the database, associated with the user (not shown in this example)

        var message = $@"
        <h3>קוד אימות לאפליקצית לקנות נדלן</h3>
        <p>קוד האימו שלך הוא: <strong>{verificationCode}</strong></p>
        <p>אנא אמת את קוד האימות</p>
        ";

        try
        {
            await _emailService.SendEmailAsync(user.Email, "קוד אימות", message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Email sending failed: {ex.Message}");
        }
        return Ok();
    }
}

public class VerificationRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}

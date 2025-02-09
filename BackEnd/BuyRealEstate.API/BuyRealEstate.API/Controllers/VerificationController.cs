using BuyRealEstate.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Data;
using System.Security.Claims;
using BuyRealEstate.Core.DTos;

[Route("api/[controller]")]
[ApiController]
public class VerificationController : ControllerBase
{
    private readonly IVerificationService _verificationService;

    public VerificationController(IVerificationService verificationService)
    {
        _verificationService = verificationService;
    }

    [HttpPost("SendVerificationCode")]
    public async Task<IActionResult> SendVerificationCode([FromBody] VerificationRequest request)
    {
        if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest("Username and password are required.");
        }

        var result = await _verificationService.SendVerificationCodeAsync(request.Username, request.Password);

        if (!result.IsSuccessful)
        {
            return Unauthorized(result.ErrorMessage);
        }

        return Ok(new
        {
            message = "Verification code sent successfully.",
            userId = result.UserId
        });
    }


[HttpPost("VerifyCode")]
    public IActionResult VerifyCode([FromBody] VerifyCodeRequest request)
    {
        if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Code))
        {
            return BadRequest("Username and code are required.");
        }

        var success = _verificationService.VerifyCode(request.Username, request.Code);
        if (!success)
        {
            return Unauthorized("Invalid verification code.");
        }

        return Ok(new { message = "Verification successful." });
    }
}



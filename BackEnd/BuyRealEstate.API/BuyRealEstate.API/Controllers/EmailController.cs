using Microsoft.AspNetCore.Mvc;

namespace BuyRealEstate.API.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class EmailController : ControllerBase
        {
            private readonly EmailService _emailService;

            public EmailController(EmailService emailService)
            {
                _emailService = emailService;
            }

            [HttpPost("send")]
            public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
            {
                try
                {
                    await _emailService.SendEmailAsync(request.To, request.Subject, request.Body);
                    return Ok("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Failed to send email: {ex.Message}");
                }
            }
        }

        public class EmailRequest
        {
            public string To { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        }

    
}

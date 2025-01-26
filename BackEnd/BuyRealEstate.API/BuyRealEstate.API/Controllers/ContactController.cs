//using Microsoft.AspNetCore.Mvc;
//using YourProject.API.Models;
//using YourProject.API.Services;

//namespace YourProject.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ContactController : ControllerBase
//    {
//        private readonly IEmailService _emailService;

//        public ContactController(IEmailService emailService)
//        {
//            _emailService = emailService;
//        }

//        [HttpPost]
//        public async Task<IActionResult> SendEmail([FromBody] ContactFormModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            await _emailService.SendEmailAsync(model);
//            return Ok("Email sent successfully.");
//        }
//    }
//}
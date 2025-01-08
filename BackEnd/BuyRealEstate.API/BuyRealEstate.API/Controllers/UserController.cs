using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.Services;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UsersDTO request)
    {
        if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest("Invalid login request.");
        }

        var user = await _userService.LoginAsync(request.Username, request.Password);
        if (user != null)
        {
            return Ok(user); // Return success response with user data
        }
        return Unauthorized("Invalid username or password."); // Return error response
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var user = await _userService.GetByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
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
        return CreatedAtAction(nameof(GetById), new { id = userDto.ID }, userDto);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UsersDTO userDto)
    {
        if (userDto == null)
        {
            return BadRequest("User data is required.");
        }
        await _userService.UpdateAsync(userDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _userService.DeleteAsync(id);
        return NoContent();
    }
}

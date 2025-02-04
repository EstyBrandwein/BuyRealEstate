using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.DTos;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        var validationErrors = ValidateUser(userDto);
        if (validationErrors.Any())
        {
            return BadRequest(validationErrors);
        }

        await _userService.AddAsync(userDto);
        return CreatedAtAction(nameof(Get), new { id = userDto.ID }, userDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UsersDTO userDto)
    {
        var validationErrors = ValidateUser(userDto);
        if (validationErrors.Any())
        {
            return BadRequest(validationErrors);
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

    private List<string> ValidateUser(UsersDTO user)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(user.Username))
            errors.Add("שם משתמש הוא שדה חובה");
        else if (user.Username.Length < 3 || !Regex.IsMatch(user.Username, "^[א-תa-zA-Z]+$"))
            errors.Add("שם המשתמש חייב להיות באורך מינימלי של 3 תווים ולכלול רק אותיות בשפה אחת");

        if (string.IsNullOrWhiteSpace(user.FirstName) || user.FirstName.Length < 2 || !Regex.IsMatch(user.FirstName, "^[א-תa-zA-Z]+$"))
            errors.Add("שם פרטי חייב להיות באורך מינימלי של 2 תווים ולכלול רק אותיות בשפה אחת");

        if (string.IsNullOrWhiteSpace(user.LastName) || user.LastName.Length < 2 || !Regex.IsMatch(user.LastName, "^[א-תa-zA-Z]+$"))
            errors.Add("שם משפחה חייב להיות באורך מינימלי של 2 תווים ולכלול רק אותיות בשפה אחת");

        if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
            errors.Add("כתובת המייל אינה תקינה");

        if (!string.IsNullOrWhiteSpace(user.FirstPhone) && (!Regex.IsMatch(user.FirstPhone, "^\\d+$") || user.FirstPhone.Length < 7 || user.FirstPhone.Length > 15))
            errors.Add("מספר טלפון 1 חייב להיות בין 7 ל-15 ספרות");

        if (!string.IsNullOrWhiteSpace(user.SecendPhon) && (!Regex.IsMatch(user.SecendPhon, "^\\d+$") || user.SecendPhon.Length < 7 || user.SecendPhon.Length > 15))
            errors.Add("מספר טלפון 2 חייב להיות בין 7 ל-15 ספרות");

        return errors;
    }
}

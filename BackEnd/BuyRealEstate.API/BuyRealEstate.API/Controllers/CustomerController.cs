using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Models;
using Microsoft.AspNetCore.Identity.Data;
using BuyRealEstate.Core.DTos;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] CustomerLoginRequest request)
    {
        if (request == null || string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest("Invalid login request.");
        }

        var customer = await _customerService.LoginAsync(request.Username, request.Password);
        if (customer != null)
        {
            return Ok(customer); // Return success response with customer data
        }
        return Unauthorized("Invalid username or password."); // Return error response
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var customer = await _customerService.GetByIdAsync(id);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _customerService.GetAllAsync();
        return Ok(customers);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Customer customer)
    {
        if (customer == null)
        {
            return BadRequest("Customer data is required.");
        }
        await _customerService.AddAsync(customer);
        return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Customer customer)
    {
        if (customer == null)
        {
            return BadRequest("Customer data is required.");
        }
        await _customerService.UpdateAsync(customer);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _customerService.DeleteAsync(id);
        return NoContent();
    }
}

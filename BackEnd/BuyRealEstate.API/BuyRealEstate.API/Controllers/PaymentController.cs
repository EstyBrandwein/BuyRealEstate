using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BuyRealEstate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController: ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayments()
        {
            var payments = await _paymentService.GetAllPaymentsAsync();
            return Ok(payments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPayment(int id)
        {
            var payment = await _paymentService.GetPaymentByIdAsync(id);
            if (payment == null) return NotFound();
            return Ok(payment);
        }

        [HttpPost]
        public async Task<IActionResult> AddPayment(PaymentDTO payment)
        {
            await _paymentService.AddPaymentAsync(payment);
            return CreatedAtAction(nameof(GetPayment), payment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, PaymentDTO payment)
        {
            await _paymentService.UpdatePaymentAsync(payment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            await _paymentService.DeletePaymentAsync(id);
            return NoContent();
        }
    }
}

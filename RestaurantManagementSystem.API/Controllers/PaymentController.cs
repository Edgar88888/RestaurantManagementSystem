using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services;
using RestaurantManagementSystem.Business.Services.Interfaces;

namespace RestaurantManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        [Route("addpayment")]
        public async Task<IActionResult> AddPaymentAsync([FromBody] PaymentAddDto paymennt)
        {
            return Ok(await _paymentService.AddPaymentAsync(paymennt));
        }

    }
}

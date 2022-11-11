using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services;
using RestaurantManagementSystem.Business.Services.Interfaces;

namespace RestaurantManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _orderService.GetAllAsync());
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _orderService.GetByIdAsync(id));
        }

        [HttpPut]
        [Route("create")]
        public async Task<IActionResult> CreateAsync([FromBody] OrderCreateDto orderDto)
        {
            await _orderService.CreateAsync(orderDto);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] int id)
        {
            await _orderService.DeleteAsync(id);
            return Ok();
        }

    }
}

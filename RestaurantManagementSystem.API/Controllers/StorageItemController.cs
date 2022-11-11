using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services.Interfaces;

namespace RestaurantManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageItemController : ControllerBase
    {
        private readonly IStorageItemService _storageItemService;
        public StorageItemController(IStorageItemService storageItemService)
        {
            _storageItemService = storageItemService;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAsync(bool onlyAvailable) 
        { 
            return Ok(await _storageItemService.GetAllAsync(onlyAvailable));
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _storageItemService.GetByIdAsync(id));
        }

        [HttpPut]
        [Route("add")]
        public async Task<IActionResult> AddAsync([FromBody] StorageItemDto storageItem)
        {
            await _storageItemService.AddAsync(storageItem);
            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] StorageItemDto storageItem)
        {
            await _storageItemService.UpdateAsync(storageItem);
            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] StorageItemDto storageItem)
        {
            await _storageItemService.UpdateAsync(storageItem);
            return Ok();
        }

        [HttpPost]
        [Route("updateavailability")]
        public async Task<IActionResult> UpdateAvailabilityAsync([FromBody] int productId, bool isEnabled)
        {
            await _storageItemService.UpdateAvailabilityAsync(productId, isEnabled);
            return Ok();
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Business.Services;
using RestaurantManagementSystem.Business.Services.Interfaces;

namespace RestaurantManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet]
        [Route("currentstorageitem")]
        public async Task<IActionResult> GetAllStorageItemForReportAsync()
        {
            return Ok(await _reportService.GetAllStorageItemForReportAsync());
        }
        [HttpGet]
        [Route("employeesservinghistory")]
        public async Task<IActionResult> GetEmployeesServingHistoryAsync()
        {
            return Ok(await _reportService.EmployeesServingHistoryAsync());
        }
        [HttpGet]
        [Route("menuhistory")]
        public async Task<IActionResult> GetMenuHistoryAsync()
        {
            return Ok(await _reportService.GetMenuHistoryAsync());
        }

    }
}

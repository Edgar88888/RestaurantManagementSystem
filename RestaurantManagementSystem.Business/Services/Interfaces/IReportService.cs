using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services.Interfaces
{
    public interface IReportService
    {
        Task<List<StorageItemDto>> GetAllStorageItemForReportAsync();
        Task<List<UserDto>> EmployeesServingHistoryAsync();
        Task<List<MenuHistoryDto>> GetMenuHistoryAsync();

    }
}

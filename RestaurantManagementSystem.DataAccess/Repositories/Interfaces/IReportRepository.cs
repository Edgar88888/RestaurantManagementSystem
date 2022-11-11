using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Repositories.Interfaces
{
    public interface IReportRepository
    {
        Task<List<StorageItem>> GetAllStorageItemForReportAsync();
        Task<List<ApplicationUser>> EmployeesServingHistoryAsync();
        Task<List<MenuHistory>> GetMenuHistoryAsync();
    }
}

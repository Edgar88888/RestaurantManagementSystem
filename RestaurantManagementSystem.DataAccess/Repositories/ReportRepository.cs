using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Enums;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System.Security.Cryptography;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly RMSDataContext _context;
        public ReportRepository(RMSDataContext context)
        {
            _context = context;
        }

        public async Task<List<StorageItem>> GetAllStorageItemForReportAsync()
        {
            return await _context.StorageItems.Where(x => x.Count > 0).ToListAsync();
        }

        public async Task<List<ApplicationUser>> EmployeesServingHistoryAsync()
        {
            return await (from u in _context.Users.Include(x => x.WaiterOrders)
                           join ur in _context.UserRoles on u.Id equals ur.UserId
                           join r in _context.Roles on ur.RoleId equals r.Id
                           where r.Id == (int)Role.Client
                           group u by u.Id
                           ).Select(x => x.FirstOrDefault()).ToListAsync();
        }

        public async Task<List<MenuHistory>> GetMenuHistoryAsync()
        {
            return await _context.MenuHistories.ToListAsync();
        }
    }
}

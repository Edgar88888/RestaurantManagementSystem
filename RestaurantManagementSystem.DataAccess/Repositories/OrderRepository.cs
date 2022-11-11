using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RMSDataContext _context;
        public OrderRepository(RMSDataContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.Include(x => x.OrderStorageItems)
                .ThenInclude(x => x.StorageItem)
                .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _context.Orders
                .Include(x => x.OrderStorageItems)
                .ThenInclude(x => x.StorageItem)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CreateAsync(Order order)
        {
            var itemsId = order.OrderStorageItems.Select(x => x.StorageItemId).ToList();
            var storageItems = await _context.StorageItems.Where(x => itemsId.Contains(x.Id)).ToListAsync();
            foreach (var item in order.OrderStorageItems)
            {
                var storageItem = storageItems.FirstOrDefault(x => x.Id == item.StorageItemId);
                if (item.Serving > storageItem.Count)
                    throw new Exception("Not so many products in storage");
                else
                {
                    storageItem.Count = storageItem.Count - item.Serving;
                }
            }
            await _context.Orders.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
            if (order == null)
            {
                throw new Exception("Selected order not found.");
            }
            order.IsDeleted = true;
        }

    }
}

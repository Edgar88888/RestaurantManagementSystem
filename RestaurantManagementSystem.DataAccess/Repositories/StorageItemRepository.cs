using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class StorageItemRepository : IStorageItemRepository
    {
        private readonly RMSDataContext _context;
        public StorageItemRepository(RMSDataContext context)
        {
            _context = context;
        }

        public async Task<List<StorageItem>> GetAllAsync(bool onlyAvailable = false)
        {
            return await _context.StorageItems.Where(x => !onlyAvailable || (x.EnableInMenu && x.Count > 0)).ToListAsync();
        }
        public async Task<StorageItem> GetByIdAsync(int Id)
        {
            return await _context.StorageItems.FindAsync(Id);
        }
        public async Task AddAsync(StorageItem model)
        {
            await _context.AddAsync(model);

            await _context.SaveChangesAsync();
            if (model.EnableInMenu)
            {
                MenuHistory history = new MenuHistory()
                {
                    MenueItemId = model.Id,
                    Data = JsonSerializer.Serialize(model)
                };
                await _context.MenuHistories.AddAsync(history);
            }
        }
        public async Task UpdateAsync(StorageItem model)
        {
            var storageItem = await _context.StorageItems.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (storageItem == null)
            {
                throw new Exception("Selected StorageItem not found.");
            }

            bool isNotInMenue = false;
            if (!storageItem.EnableInMenu && !model.EnableInMenu)
                isNotInMenue = true;

            //delete 
            if (model.IsDeleted)
                storageItem.IsDeleted = true;
            //update
            else
            {
                storageItem.Name = model.Name;
                storageItem.Description = model.Description;
                storageItem.Price = model.Price;
                storageItem.Count = model.Count;
                storageItem.EnableInMenu = model.EnableInMenu;
                storageItem.UpdatedDate = DateTime.Now;
            }

            if (isNotInMenue)
            {
                MenuHistory history = new MenuHistory()
                {
                    MenueItemId = storageItem.Id,
                    Data = JsonSerializer.Serialize(storageItem)
                };
                await _context.MenuHistories.AddAsync(history);
            }
        }

        public async Task UpdateAvailabilityAsync(int productId, bool isEnabled)
        {
            var storageItem = await _context.StorageItems.SingleOrDefaultAsync(x => x.Id == productId);
            if (storageItem == null)
            {
                throw new Exception("Selected StorageItem not found.");
            }

            storageItem.EnableInMenu = isEnabled;

            MenuHistory history = new MenuHistory()
            {
                MenueItemId = storageItem.Id,
                Data = JsonSerializer.Serialize(storageItem)
            };
            await _context.MenuHistories.AddAsync(history);

        }
    }
}

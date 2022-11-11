using RestaurantManagementSystem.DataAccess.Entities;

namespace RestaurantManagementSystem.DataAccess.Repositories.Interfaces
{
    public interface IStorageItemRepository
    {
        Task<List<StorageItem>> GetAllAsync(bool onlyAvailable = false);
        Task<StorageItem> GetByIdAsync(int Id);
        Task AddAsync(StorageItem model);
        Task UpdateAsync(StorageItem model);
        Task UpdateAvailabilityAsync(int productId, bool isEnabled);
    }
}

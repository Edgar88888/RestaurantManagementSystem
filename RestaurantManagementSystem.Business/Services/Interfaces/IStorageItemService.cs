using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;

namespace RestaurantManagementSystem.Business.Services.Interfaces
{
    public interface IStorageItemService
    {
        Task<List<StorageItemDto>> GetAllAsync(bool onlyAvailable = false);
        Task<StorageItemDto> GetByIdAsync(int Id);
        Task AddAsync(StorageItemDto model);
        Task UpdateAsync(StorageItemDto model);
        Task UpdateAvailabilityAsync(int productId, bool isEnabled);
    }
}

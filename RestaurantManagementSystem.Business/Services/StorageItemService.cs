using AutoMapper;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services.Interfaces;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;

namespace RestaurantManagementSystem.Business.Services
{
    public class StorageItemService : IStorageItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StorageItemService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StorageItemDto>> GetAllAsync(bool onlyAvailable = false)
        {
            return _mapper.Map<List<StorageItemDto>>(await _unitOfWork.StorageItemRepository.GetAllAsync(onlyAvailable));
        }
        public async Task<StorageItemDto> GetByIdAsync(int Id)
        {
            return _mapper.Map<StorageItemDto>(await _unitOfWork.StorageItemRepository.GetByIdAsync(Id));
        }
        public async Task AddAsync(StorageItemDto model)
        {
            await _unitOfWork.StorageItemRepository.AddAsync(_mapper.Map<StorageItem>(model));
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateAsync(StorageItemDto model)
        {
            await _unitOfWork.StorageItemRepository.UpdateAsync(_mapper.Map<StorageItem>(model));
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateAvailabilityAsync(int productId, bool isEnabled)
        {
            await _unitOfWork.StorageItemRepository.UpdateAvailabilityAsync(productId, isEnabled);
            await _unitOfWork.SaveAsync();
        }
    }
}

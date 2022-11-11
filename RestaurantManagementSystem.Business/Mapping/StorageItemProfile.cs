using AutoMapper;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;

namespace RestaurantManagementSystem.Business.Mapping
{
    public class StorageItemProfile : Profile
    {
        public StorageItemProfile()
        {
            CreateMap<StorageItem, StorageItemDto>();
            CreateMap<StorageItemDto, StorageItem>();
        }
    }
}

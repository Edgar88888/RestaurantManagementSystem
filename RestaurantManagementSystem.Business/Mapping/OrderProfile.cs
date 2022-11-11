using AutoMapper;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;

namespace RestaurantManagementSystem.Business.Mapping
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<OrderStorageItem, OrderStorageItemDto>();
            CreateMap<OrderStorageItemDto, OrderStorageItem>();

            CreateMap<OrderCreateDto, Order>();
            CreateMap<OrderStorageItemCreateDto, OrderStorageItem>();

        }
    }
}

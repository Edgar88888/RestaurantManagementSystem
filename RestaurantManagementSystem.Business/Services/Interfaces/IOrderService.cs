using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllAsync();
        Task<OrderDto> GetByIdAsync(int id);
        Task CreateAsync(OrderCreateDto order);
        Task DeleteAsync(int id);
    }
}

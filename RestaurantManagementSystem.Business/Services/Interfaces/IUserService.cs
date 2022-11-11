using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllAsync();
        Task<UserDto> GetByIdAsync(int Id);
        Task UpdateAsync(UserUpdateDto model);
        Task DeleteAsync(int Id);
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services.Interfaces;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            return _mapper.Map<List<UserDto>>(await _unitOfWork.UserRepository.GetAllAsync());
        }
        public async Task<UserDto> GetByIdAsync(int Id)
        {
            return _mapper.Map<UserDto>(await _unitOfWork.UserRepository.GetByIdAsync(Id));
        }
        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.UserRepository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateAsync(UserUpdateDto model)
        {
            await _unitOfWork.UserRepository.UpdateAsync(_mapper.Map<ApplicationUser>(model));
            await _unitOfWork.SaveAsync();
        }
    }
}

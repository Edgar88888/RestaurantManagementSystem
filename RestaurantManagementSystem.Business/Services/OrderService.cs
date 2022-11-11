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
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<OrderDto>> GetAllAsync()
        {
            return _mapper.Map<List<OrderDto>>(await _unitOfWork.OrderRepository.GetAllAsync());
        }

        public async Task<OrderDto> GetByIdAsync(int id)
        {
            return _mapper.Map<OrderDto>(await _unitOfWork.OrderRepository.GetByIdAsync(id));
        }

        public async Task CreateAsync(OrderCreateDto order)
        {
            await _unitOfWork.OrderRepository.CreateAsync(_mapper.Map<Order>(order));
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.OrderRepository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }
    }
}

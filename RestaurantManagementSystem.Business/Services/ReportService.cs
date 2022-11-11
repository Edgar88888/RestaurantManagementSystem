using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.Business.Services.Interfaces;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Enums;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StorageItemDto>> GetAllStorageItemForReportAsync()
        {
            return _mapper.Map<List<StorageItemDto>>(await _unitOfWork.ReportRepository.GetAllStorageItemForReportAsync());
        }

        public async Task<List<UserDto>> EmployeesServingHistoryAsync()
        {
            return _mapper.Map<List<UserDto>>(await _unitOfWork.ReportRepository.EmployeesServingHistoryAsync());
        }

        public async Task<List<MenuHistoryDto>> GetMenuHistoryAsync()
        {
            return _mapper.Map<List<MenuHistoryDto>>(await _unitOfWork.ReportRepository.GetMenuHistoryAsync());
        }

    }
}

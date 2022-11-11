using AutoMapper;
using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Mapping
{
    public class MenuHistoryProfile : Profile
    {
        public MenuHistoryProfile() 
        {
            CreateMap<MenuHistory, MenuHistoryDto>();
        }
    }
}

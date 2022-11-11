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
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentDto, Payment>();
            CreateMap<Payment, PaymentDto>();
            CreateMap<PaymentDto, InvoiceDto>()
                .ForMember(x => x.PaymentDate, o => o.MapFrom(i => i.CreatedDate))
                .ForMember(x => x.TotalSum, o => o.MapFrom(i => i.Order.OrderStorageItems.Sum(x => x.StorageItem.Price * x.Serving)))
                .ForMember(x => x.Items, o => o.MapFrom(i => i.Order.OrderStorageItems));

            CreateMap<OrderStorageItemDto, StorageItemForInvoiceDto>()
                .ForMember(x => x.Name, o => o.MapFrom(i => i.StorageItem.Name))
                .ForMember(x => x.Price, o => o.MapFrom(i => i.StorageItem.Price))
                .ForMember(x => x.Serving, o => o.MapFrom(i => i.Serving))
                .ForMember(x => x.Total, o => o.MapFrom(i => i.StorageItem.Price * i.Serving));
            CreateMap<PaymentAddDto, Payment>();
        }
    }
}

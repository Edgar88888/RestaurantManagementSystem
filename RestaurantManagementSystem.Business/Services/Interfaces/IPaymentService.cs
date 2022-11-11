using RestaurantManagementSystem.Business.Dtos;
using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Business.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<InvoiceDto> AddPaymentAsync(PaymentAddDto payment);
    }
}

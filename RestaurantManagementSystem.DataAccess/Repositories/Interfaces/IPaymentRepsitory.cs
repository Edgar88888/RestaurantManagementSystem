using RestaurantManagementSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Repositories.Interfaces
{
    public interface IPaymentRepsitory
    {
        Task<Payment> AddPaymentAsync(Payment payment);
    }
}

using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class PaymentRepsitory : IPaymentRepsitory
    {
        private readonly RMSDataContext _context;
        public PaymentRepsitory(RMSDataContext context)
        {
            _context = context;
        }

        public async Task<Payment> AddPaymentAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            return await _context.Payments
                .Include(x=>x.Order)
                .ThenInclude(x=>x.OrderStorageItems)
                .ThenInclude(x=>x.StorageItem).FirstOrDefaultAsync(x=>x.Id == payment.Id);
        }
    }
}

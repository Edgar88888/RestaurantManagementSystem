using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.DataAccess.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IStorageItemRepository StorageItemRepository { get; }
        IOrderRepository OrderRepository { get; }
        IReportRepository ReportRepository { get; }
        IPaymentRepsitory PaymentRepsitory { get; }
        Task SaveAsync();
    }
}

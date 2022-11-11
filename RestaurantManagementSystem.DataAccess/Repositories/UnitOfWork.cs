using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RMSDataContext _context;
        public UnitOfWork(RMSDataContext context)
        {
            _context = context;
        }
        private IUserRepository _userRepository;
        private IStorageItemRepository _storageItemRepository;
        private IOrderRepository _orderRepository;
        private IReportRepository _reportRepository;
        private IPaymentRepsitory _paymentRepsitory;


        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);
        public IStorageItemRepository StorageItemRepository => _storageItemRepository ?? new StorageItemRepository(_context);
        public IOrderRepository OrderRepository => _orderRepository ?? new OrderRepository(_context);
        public IReportRepository ReportRepository => _reportRepository ?? new ReportRepository(_context);
        public IPaymentRepsitory PaymentRepsitory => _paymentRepsitory ?? new PaymentRepsitory(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

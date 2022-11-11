using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.DataAccess.Entities;
using RestaurantManagementSystem.DataAccess.Repositories.Interfaces;

namespace RestaurantManagementSystem.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly RMSDataContext _context;
        public UserRepository(RMSDataContext context)
        {
            _context = context;
        }
        public async Task<List<ApplicationUser>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<ApplicationUser> GetByIdAsync(int Id)
        {
            return await _context.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                throw new Exception("Selected user not found.");
            }
            user.IsDeleted = true;
        }
        public async Task UpdateAsync(ApplicationUser model)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (user == null)
            {
                throw new Exception("Selected user not found.");
            }
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.Email = model.Email;
            user.UserName = model.Email;
            user.NormalizedEmail= model.Email.ToUpper();
            user.NormalizedUserName = model.Email.ToUpper();
        }
    }
}

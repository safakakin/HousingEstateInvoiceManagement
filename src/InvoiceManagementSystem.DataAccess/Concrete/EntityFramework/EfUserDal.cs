using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, InvoiceManagementSystemDbContext>, IUserDal
    {
        private readonly InvoiceManagementSystemDbContext _context;
        public EfUserDal(InvoiceManagementSystemDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Role> GetClaimAsync(User user)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(x => x.Id == user.RoleId);

            return role;
        }
    }
}
using Core.DataAccess;
using Core.Entities.Concrete;

namespace RezervationSystem.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        Task<Role> GetClaimAsync(User user);
    }
}
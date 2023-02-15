using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfCardDal : EfRepositoryBase<Card, InvoiceManagementSystemDbContext>, ICardDal
    {
        public EfCardDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
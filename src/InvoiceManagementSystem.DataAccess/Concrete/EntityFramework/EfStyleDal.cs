using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfStyleDal : EfRepositoryBase<Style, InvoiceManagementSystemDbContext>, IStyleDal
    {
        public EfStyleDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
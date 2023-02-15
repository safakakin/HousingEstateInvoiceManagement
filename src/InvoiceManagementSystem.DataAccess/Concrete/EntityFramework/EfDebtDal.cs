using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfDebtDal : EfRepositoryBase<Debt, InvoiceManagementSystemDbContext>, IDebtDal
    {
        public EfDebtDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
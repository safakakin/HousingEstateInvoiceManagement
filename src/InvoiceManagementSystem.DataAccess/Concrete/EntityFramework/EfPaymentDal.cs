using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : EfRepositoryBase<Payment, InvoiceManagementSystemDbContext>, IPaymentDal
    {
        public EfPaymentDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
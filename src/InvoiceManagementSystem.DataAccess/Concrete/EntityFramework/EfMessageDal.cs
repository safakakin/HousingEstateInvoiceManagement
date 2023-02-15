using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal : EfRepositoryBase<Message, InvoiceManagementSystemDbContext>, IMessageDal
    {
        public EfMessageDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
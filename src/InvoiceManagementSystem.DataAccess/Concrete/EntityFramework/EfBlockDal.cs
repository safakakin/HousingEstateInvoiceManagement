using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfBlockDal : EfRepositoryBase<Block, InvoiceManagementSystemDbContext>, IBlockDal
    {
        public EfBlockDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}
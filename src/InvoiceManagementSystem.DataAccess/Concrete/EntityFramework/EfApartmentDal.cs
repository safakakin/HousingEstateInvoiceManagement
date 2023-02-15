using Core.DataAccess.EntityFramework;
using InvoiceManagementSystem.Dto.Concrete.ApartmansDebts;
using Microsoft.EntityFrameworkCore;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfApartmentDal : EfRepositoryBase<Apartment, InvoiceManagementSystemDbContext>, IApartmentDal
    {
        private readonly InvoiceManagementSystemDbContext _context;
        public EfApartmentDal(InvoiceManagementSystemDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ApartmentsDebts>> ApartmentsDebtsReadDtosAsync()
        {
            var apartments = _context.Apartments.AsQueryable().Include(x => x.Block).Include(x => x.Style).Include(x => x.Customer);
            var debts = _context.Debts.AsNoTracking().AsQueryable();
            var payments = _context.Payments.AsNoTracking().AsQueryable();
            var total = payments.Sum(x => x.Cost) - debts.Sum(x => x.Cost);

            List<ApartmentsDebts> apartmentsDebtsReadDtos = apartments.Select(aparment => new ApartmentsDebts()
            {
                Apartment = aparment,
                Payment = payments.Where(x => x.ApartmentID == aparment.Id).ToList(),
                Debt = debts.Where(x => x.ApartmentID == aparment.Id).ToList(),
                TotalDebt = total
            }).ToList();

            return apartmentsDebtsReadDtos;
        }
    }
}
using Core.DataAccess;
using InvoiceManagementSystem.Dto.Concrete.ApartmansDebts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Abstract
{
    public interface IApartmentDal : IRepository<Apartment>
    {
        Task<List<ApartmentsDebts>> ApartmentsDebtsReadDtosAsync();
    }
}
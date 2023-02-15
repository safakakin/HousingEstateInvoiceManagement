using InvoiceManagementSystem.Dto.Concrete.ApartmansDebts;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Business.Services.Abstract
{
    public interface IApartmentService : IBaseService<Apartment, ApartmentWriteDto, ApartmentReadDto>
    {
        Task<List<ApartmentsDebtsReadDto>> ApartmentsDebtsReadDtosAsync();
    }
}
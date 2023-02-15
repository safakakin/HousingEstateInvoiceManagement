using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Business.Services.Abstract
{
    public interface IDebtService : IBaseService<Debt, DebtWriteDto, DebtReadDto>
    {
    }
}
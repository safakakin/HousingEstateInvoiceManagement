using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    public class DebtManager : BaseManager<Debt, DebtWriteDto, DebtReadDto>, IDebtService
    {
        public DebtManager(IDebtDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(DebtWriteDtoValidator))]
        public override async Task<DataResult<DebtReadDto>> AddAsync(DebtWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(DebtWriteDtoValidator))]
        public async override Task<DataResult<DebtReadDto>> UpdateAsync(int id, DebtWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<DebtReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin,Customer")]
        public override async Task<DataResult<DebtReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<IPaginate<DebtReadDto>>> GetListAsync(
            Expression<Func<Debt, bool>>? predicate = null, 
            Func<IQueryable<Debt>, IOrderedQueryable<Debt>>? orderBy = null, 
            Func<IQueryable<Debt>, IIncludableQueryable<Debt, object>>? include = null, 
            int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, (queryable) => {
                queryable = queryable.Include(a => a.Customer).Include(a => a.Apartment);
                return (IIncludableQueryable<Debt, object>)queryable;
            }, index, size, enamleTracking, cancellationToken);
        }
    }
}

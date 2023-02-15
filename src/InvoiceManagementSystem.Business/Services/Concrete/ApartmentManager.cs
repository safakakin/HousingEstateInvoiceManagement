using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using InvoiceManagementSystem.Dto.Concrete.ApartmansDebts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;
using System.Linq;
using Mapster;

namespace RezervationSystem.Business.Services.Concrete
{
    public class ApartmentManager : BaseManager<Apartment, ApartmentWriteDto, ApartmentReadDto>, IApartmentService
    {
        private readonly IApartmentDal _apartmentDal;
        public ApartmentManager(IApartmentDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
            _apartmentDal = repository;
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(ApartmentWriteDtoValidator))]
        public override async Task<DataResult<ApartmentReadDto>> AddAsync(ApartmentWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<ApartmentReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(ApartmentWriteDtoValidator))]
        public async override Task<DataResult<ApartmentReadDto>> UpdateAsync(int id, ApartmentWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin,Customer")]
        public override Task<DataResult<IPaginate<ApartmentReadDto>>> GetListAsync(
            Expression<Func<Apartment, bool>>? predicate = null, 
            Func<IQueryable<Apartment>, IOrderedQueryable<Apartment>>? orderBy = null, 
            Func<IQueryable<Apartment>, IIncludableQueryable<Apartment, object>>? include = null, 
            int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(predicate, orderBy, (queryable) => {
                queryable = queryable.Include(a => a.Block).Include(a => a.Style);
                return (IIncludableQueryable<Apartment, object>)queryable;
            }, index, size, enamleTracking, cancellationToken);
        }

        [SecuretOperation("Admin,Customer")]
        public override async Task<DataResult<ApartmentReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        public async Task<List<ApartmentsDebtsReadDto>> ApartmentsDebtsReadDtosAsync()
        {
            List<ApartmentsDebts> apartmentsDebts = await _apartmentDal.ApartmentsDebtsReadDtosAsync();
            List<ApartmentsDebtsReadDto> apartmentsDebtsReadDtos = apartmentsDebts.Adapt<List<ApartmentsDebtsReadDto>>();
            return apartmentsDebtsReadDtos;
        }
    }
}

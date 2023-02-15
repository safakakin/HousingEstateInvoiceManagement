using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    [SecuretOperation("Admin")]
    public class StyleManager : BaseManager<Style, StyleWriteDto, StyleReadDto>, IStyleService
    {
        public StyleManager(IStyleDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(StyleWriteDtoValidator))]
        public override async Task<DataResult<StyleReadDto>> AddAsync(StyleWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(StyleWriteDtoValidator))]
        public async override Task<DataResult<StyleReadDto>> UpdateAsync(int id, StyleWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
        public override async Task<DataResult<StyleReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        public override async Task<DataResult<StyleReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        
        public override async Task<DataResult<IPaginate<StyleReadDto>>> GetListAsync(
            Expression<Func<Style, bool>>? predicate = null, 
            Func<IQueryable<Style>, IOrderedQueryable<Style>>? orderBy = null, 
            Func<IQueryable<Style>, IIncludableQueryable<Style, object>>? include = null, 
            int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }
    }
}

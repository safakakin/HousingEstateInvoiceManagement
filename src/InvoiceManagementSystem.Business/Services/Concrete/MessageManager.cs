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
    public class MessageManager : BaseManager<Message, MessageWriteDto, MessageReadDto>, IMessageService
    {
        public MessageManager(IMessageDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [SecuretOperation("Customer")]
        [ValidationAspect(typeof(MessageWriteDtoValidator))]
        public override async Task<DataResult<MessageReadDto>> AddAsync(MessageWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Customer")]
        [ValidationAspect(typeof(MessageWriteDtoValidator))]
        public async override Task<DataResult<MessageReadDto>> UpdateAsync(int id, MessageWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin,Customer")]
        public override async Task<DataResult<MessageReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<MessageReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<IPaginate<MessageReadDto>>> GetListAsync(
            Expression<Func<Message, bool>>? predicate = null, 
            Func<IQueryable<Message>, IOrderedQueryable<Message>>? orderBy = null, 
            Func<IQueryable<Message>, IIncludableQueryable<Message, object>>? include = null, 
            int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }
    }
}

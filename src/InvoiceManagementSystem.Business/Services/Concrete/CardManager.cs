using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Mapster;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    public class CardManager : BaseManager<Card, CardWriteDto, CardReadDto>, ICardService
    {
        private readonly ICardDal _cardDal;
        public CardManager(ICardDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
            _cardDal = repository;
        }

        [SecuretOperation("Admin,Customer")]
        [ValidationAspect(typeof(CardWriteDtoValidator))]
        public override async Task<DataResult<CardReadDto>> AddAsync(CardWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(CardWriteDtoValidator))]
        public override async Task<DataResult<CardReadDto>> UpdateAsync(int id, CardWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<CardReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<IPaginate<CardReadDto>>> GetListAsync(
            Expression<Func<Card, bool>>? predicate = null, 
            Func<IQueryable<Card>, IOrderedQueryable<Card>>? orderBy = null, 
            Func<IQueryable<Card>, IIncludableQueryable<Card, object>>? 
            include = null, int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<CardReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        public async Task<DataResult<CardReadDto>> GetByCardNumberAsync(int cardNumber)
        {
            Card card = await Repository.GetAsync(x => x.CardNumber == cardNumber);

            if(card == null)
                return new ErrorDataResult<CardReadDto>("Wrong Card Number");

            CardReadDto cardReadDto = card.Adapt<CardReadDto>();

            return new SuccessDataResult<CardReadDto>(cardReadDto);
        }

        public async Task<IResult> UpdateCardPaymentByCardNumber(PaymentWriteDto writeDto)
        {
            Card card = await _cardDal.GetAsync(x => x.CardNumber == writeDto.CardNumber);            

            card.Balance -= writeDto.Cost;
            writeDto.CardId = card.Id;

            var result = await _cardDal.UpdateAsync(card);

            return new SuccessResult();
        }
    }
}

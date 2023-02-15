using Core.Aspects.Autofac.Validation;
using Core.Dto;
using Core.Paging;
using Core.Utilities.Business;
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
    public class PaymentManager : BaseManager<Payment, PaymentWriteDto, PaymentReadDto>, IPaymentService
    {
        private readonly IApartmentService _apartmentService;
        private readonly ICardService _cardService;
        public PaymentManager(IPaymentDal repository, ILanguageMessage languageMessage, IApartmentService apartmentService, ICardService cardService) : base(repository, languageMessage)
        {
            _apartmentService = apartmentService;
            _cardService = cardService;
        }

        [SecuretOperation("Admin,Customer")]
        [ValidationAspect(typeof(PaymentWriteDtoValidator))]
        public override async Task<DataResult<PaymentReadDto>> AddAsync(PaymentWriteDto writeDto)
        {
            var result = BusinessRules.Run(
                await checkApartmentAsync(writeDto.ApartmentID),
                await checkCustomerAsync(writeDto.CustomerID),
                await checkCardAsync(writeDto),
                await checkCardCostAsync(writeDto));

            if (result != null)
            {
                var errorResult = new ErrorDataResult<PaymentReadDto>(result.Message);
                return errorResult;
            }
            var paymentResult = await _cardService.UpdateCardPaymentByCardNumber(writeDto);

            if (paymentResult.Success == false)
            {
                var paymentErrorResult = new ErrorDataResult<PaymentReadDto>(paymentResult.Message);
                return paymentErrorResult;
            }
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(PaymentWriteDtoValidator))]
        public async override Task<DataResult<PaymentReadDto>> UpdateAsync(int id, PaymentWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<PaymentReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<PaymentReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<IPaginate<PaymentReadDto>>> GetListAsync(
            Expression<Func<Payment, bool>>? predicate = null, 
            Func<IQueryable<Payment>, IOrderedQueryable<Payment>>? orderBy = null, 
            Func<IQueryable<Payment>, IIncludableQueryable<Payment, object>>? 
            include = null, int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, (queryable) => {
                queryable = queryable.Include(a => a.Customer).Include(a => a.Apartment);
                return (IIncludableQueryable<Payment, object>)queryable;
            }, index, size, enamleTracking, cancellationToken);
        }

        private async Task<IResult> checkCustomerAsync(int customerId)
        {
            return new SuccessResult();
        }

        private async Task<IResult> checkApartmentAsync(int apartmentId)
        {
            var result = await _apartmentService.GetByIdAsync(apartmentId);

            if (result.Success == false)
                return new ErrorResult();

            return new SuccessResult();
        }

        private async Task<IResult> checkCardAsync(PaymentWriteDto writeDto)
        {
            var result = await _cardService.GetByCardNumberAsync(writeDto.CardNumber);

            if (result.Success == false)
                return new ErrorResult();

            return new SuccessResult();
        }

        private async Task<IResult> checkCardCostAsync(PaymentWriteDto writeDto)
        {
            var result = await _cardService.GetByCardNumberAsync(writeDto.CardNumber);

            if(result.Data.Balance < writeDto.Cost)
                return new ErrorResult("Cost can not be greated then balance");

            return new SuccessResult();
        }
    }
}

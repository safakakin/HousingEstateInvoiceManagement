using Core.Utilities.Result;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Business.Services.Abstract
{
    public interface ICardService : IBaseService<Card, CardWriteDto, CardReadDto>
    {
        Task<DataResult<CardReadDto>> GetByCardNumberAsync(int cardNumber);
        Task<IResult> UpdateCardPaymentByCardNumber(PaymentWriteDto writeDto);
    }
}
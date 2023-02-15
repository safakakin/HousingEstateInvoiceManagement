using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class CardWriteDtoValidator : AbstractValidator<CardWriteDto>
    {
        public CardWriteDtoValidator()
        {
            RuleFor(r => r.CardNumber)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(10000000)
                .LessThanOrEqualTo(99999999);

            RuleFor(r => r.CardPassword)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(1000)
                .LessThanOrEqualTo(9999);

            RuleFor(r => r.Balance)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(10000);

            RuleFor(r => r.CustomerID)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}

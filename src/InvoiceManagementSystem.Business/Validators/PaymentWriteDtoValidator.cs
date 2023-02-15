using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class PaymentWriteDtoValidator : AbstractValidator<PaymentWriteDto>
    {
        public PaymentWriteDtoValidator()
        {
            RuleFor(r => r.CustomerID)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(r => r.ApartmentID)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(r => r.Cost)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}

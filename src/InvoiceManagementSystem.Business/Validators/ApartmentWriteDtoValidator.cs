using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class ApartmentWriteDtoValidator : AbstractValidator<ApartmentWriteDto>
    {
        public ApartmentWriteDtoValidator()
        {
            RuleFor(r => r.BlockID)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(r => r.StyleID)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(r => r.Floor)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .LessThanOrEqualTo(20);
        }
    }
}

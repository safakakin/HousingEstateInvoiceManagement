using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class StyleWriteDtoValidator : AbstractValidator<StyleWriteDto>
    {
        public StyleWriteDtoValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .NotNull()
                .Length(3);
        }
    }
}

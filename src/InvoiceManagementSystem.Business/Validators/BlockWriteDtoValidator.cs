using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class BlockWriteDtoValidator : AbstractValidator<BlockWriteDto>
    {
        public BlockWriteDtoValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .NotNull()
                .Length(7);
        }
    }
}

using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class MessageWriteDtoValidator : AbstractValidator<MessageWriteDto>
    {
        public MessageWriteDtoValidator()
        {
            RuleFor(r => r.CustomerID)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(r => r.WrotenMessage)
                .NotNull()
                .NotEmpty()
                .MaximumLength(250);
        }
    }
}

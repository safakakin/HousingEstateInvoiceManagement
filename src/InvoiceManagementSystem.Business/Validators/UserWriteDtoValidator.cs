using FluentValidation;
using RezervationSystem.Dto.Concrete;

namespace RezervationSystem.Business.Validators.FluentValidation
{
    public class UserWriteDtoValidator : AbstractValidator<UserWriteDto>
    {
        public UserWriteDtoValidator()
        {
            RuleFor(r => r.RoleId)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(2);

            RuleFor(r => r.FirstName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(2);

            RuleFor(r => r.LastName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(2);

            RuleFor(r => r.TC)
                .NotEmpty()
                .NotNull()
                .Length(11);

            RuleFor(r => r.Plate)
                .NotEmpty()
                .NotNull()
                .MaximumLength(12)
                .MinimumLength(8);

            RuleFor(r => r.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(11);

            RuleFor(r => r.Email)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(15);

            RuleFor(r => r.Password)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(5);
        }
    }
}

using FluentValidation;

namespace Application.Features.Cars.Commands.Create;
public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().NotNull().MinimumLength(2);
        // RuleFor(c => c.ModelId).NotEmpty();
    }

}

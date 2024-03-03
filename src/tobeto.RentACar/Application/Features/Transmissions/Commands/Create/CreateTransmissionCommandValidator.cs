using Application.Features.Brands.Commands.Create;
using FluentValidation;

namespace Application.Features.Transmissions.Commands.Create;
public class CreateTransmissionCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateTransmissionCommandValidator()
    {
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
    }
}

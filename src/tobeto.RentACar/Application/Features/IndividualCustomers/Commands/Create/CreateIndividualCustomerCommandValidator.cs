using FluentValidation;

namespace Application.Features.IndividualCustomers.Commands.Create;

public class CreateIndividualCustomerCommandValidator : AbstractValidator<CreateIndividualCustomerCommand>
{
    public CreateIndividualCustomerCommandValidator()
    {
        RuleFor(c => c.NationalIdentity).NotEmpty();
        RuleFor(c => c.CustomerId).NotEmpty();
    }
}
using FluentValidation;

namespace Application.Features.IndividualCustomers.Commands.Update;

public class UpdateIndividualCustomerCommandValidator : AbstractValidator<UpdateIndividualCustomerCommand>
{
    public UpdateIndividualCustomerCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.NationalIdentity).NotEmpty();
        RuleFor(c => c.CustomerId).NotEmpty();
    }
}
﻿using FluentValidation;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(i => i.Name).NotEmpty().NotNull().MinimumLength(2);
    }
}

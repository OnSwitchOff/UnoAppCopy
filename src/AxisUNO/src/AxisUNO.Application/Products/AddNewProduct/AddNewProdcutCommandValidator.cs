﻿using FluentValidation;

namespace AxisUNO.Application.Products.AddNewProduct;

internal class AddNewProductCommandValidator : AbstractValidator<AddNewProductCommand>
{
    public AddNewProductCommandValidator()
    {
        RuleFor(command => command.Name != null);
    }
}
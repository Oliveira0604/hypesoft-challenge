namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class UpdateProductPriceValidator(UpdateProductPriceRequest request) : AbstractValidator<UpdateProductPriceCommand>
{
    public UpdateProductPriceValidator()
    {
        RuleFor(x => x.request.Price)
            .NotEmpty()
            .WithMessage("O preço do produto é obrigatório.")
            .GreaterThan(0)
            .WithMessage("O preço do produto deve ser maior que zero.");
    }
}
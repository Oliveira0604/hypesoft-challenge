namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class UpdateProductStockValidator(UpdateProductStockRequest request) : AbstractValidator<UpdateProductStockCommand>
{
    public UpdateProductStockValidator()
    {
        RuleFor(x => x.request.Stock)
            .NotEmpty()
            .WithMessage("O estoque do produto é obrigatório.")
            .GreaterThan(0)
            .WithMessage("O estoque do produto deve ser maior que zero.");
    }
}
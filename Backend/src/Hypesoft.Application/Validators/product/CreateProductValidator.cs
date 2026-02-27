namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.request.Name)
            .NotEmpty()
            .WithMessage("O nome do produto é obrigatório.")
            .MinimumLength(3)
            .WithMessage("O nome do produto deve ter pelo menos 3 caracteres.");

        RuleFor(x => x.request.Price)
            .GreaterThan(0)
            .WithMessage("O preço deve ser maior que zero.");
        
        RuleFor(x => x.request.CategoryId)
            .NotEmpty()
            .WithMessage("O ID da categoria é obrigatório.");

        RuleFor(x => x.request.Description)
            .NotEmpty()
            .WithMessage("A descrição do produto é obrigatória.");
        
        RuleFor(x => x.request.Description)
            .MinimumLength(10)
            .WithMessage("A descrição do produto deve ter pelo menos 10 caracteres.")
            .MaximumLength(1000)
            .WithMessage("A descrição do produto não pode exceder 1000 caracteres.");

    }
}
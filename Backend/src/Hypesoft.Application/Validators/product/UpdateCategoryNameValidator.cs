namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class UpdateCategoryNameValidator(UpadateCategoryNameRequest request) : AbstractValidator<UpdateCategoryNameCommand>
{
    public UpdateCategoryNameValidator()
    {
        RuleFor(x => x.request.Name)
            .NotEmpty()
            .WithMessage("O nome da categoria é obrigatório.")
            .MinimumLength(3)
            .WithMessage("O nome da categoria deve ter pelo menos 3 caracteres.");
    }
}
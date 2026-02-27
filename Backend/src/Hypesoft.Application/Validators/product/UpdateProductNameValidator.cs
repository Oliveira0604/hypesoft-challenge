namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class UpdateProductNameValidator(UpdateProductNameRequest request) : AbstractValidator<UpdateProductNameCommand>
{
    public UpdateProductNameValidator()
    {
        RuleFor(x => x.request.Name)
            .NotEmpty()
            .WithMessage("O nome do produto é obrigatório.")
            .MinimumLength(3)
            .WithMessage("O nome do produto deve ter pelo menos 3 caracteres.")
            .MaximumLength(100)
            .WithMessage("O nome do produto deve ter no máximo 100 caracteres.");
    }
}
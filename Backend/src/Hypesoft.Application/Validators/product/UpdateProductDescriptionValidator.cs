namespace Hypesoft.Application.Validators;

using FluentValidation;
using Hypesoft.Application.Commands;

public class UpdateProductDescriptionValidator(UpdateProductDescriptionRequest request) : AbstractValidator<UpdateProductDescriptionCommand>
{
    public UpdateProductDescriptionValidator()
    {
        RuleFor(x => x.request.Description)
            .NotEmpty()
            .WithMessage("A descrição do produto é obrigatória.")
            .MinimumLength(10)
            .WithMessage("A descrição do produto deve ter pelo menos 10 caracteres.")
            .MaximumLength(1000)
            .WithMessage("A descrição do produto deve ter no máximo 1000 caracteres.");
    }
}
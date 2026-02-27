namespace Hypesoft.Application.Validators;

using System.Security.Cryptography.X509Certificates;
using FluentValidation;
using Hypesoft.Application.Commands;

public class CreateCategoryValidator : AbstratcValidator<CreateCategoryCommand>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.request.Name )
        .NotEmpty()
        .WithMessage("O nome da categoria é obrigatório.");
    }
}
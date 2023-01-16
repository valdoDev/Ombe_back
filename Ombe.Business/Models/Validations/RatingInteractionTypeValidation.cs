using FluentValidation;

namespace Ombe.Business.Models.Validations
{
    public class RatingInteractionTypeValidation : AbstractValidator<RatingInteractionType>
    {
        public RatingInteractionTypeValidation()
        {
            RuleFor(c => c.Value)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Description)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}

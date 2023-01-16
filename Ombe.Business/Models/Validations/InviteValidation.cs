using FluentValidation;

namespace Ombe.Business.Models.Validations
{
    public class InviteValidation : AbstractValidator<Invite>
    {
        public InviteValidation()
        {
            RuleFor(c => c.Code)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}

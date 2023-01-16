using FluentValidation;
using System;

namespace Ombe.Business.Models.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(c => c.Name)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
              .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Must(date => date > DateTime.Now.AddYears(-10)).WithMessage("A idade mínima é de 1O anos, para utilizar o app.");

            RuleFor(c => c.Email)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}

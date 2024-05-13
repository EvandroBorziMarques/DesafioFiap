using Dominio.DTO;
using FluentValidation;

namespace Dominio.Validator
{
    public class AlunoDTOValidator : AbstractValidator<AlunoDTO>
    {
        public AlunoDTOValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(a => a.Name).NotNull().WithMessage("Campo Obrigatório");
            RuleFor(a => a.Name).MaximumLength(255).WithMessage("Campo deve conter no máximo 255 caracteres.");

            RuleFor(a => a.User).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(a => a.User).NotNull().WithMessage("Campo Obrigatório");
            RuleFor(a => a.User).MaximumLength(45).WithMessage("Campo deve conter no máximo 45 caracteres.");

            RuleFor(a => a.Password).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(a => a.Password).NotNull().WithMessage("Campo Obrigatório");
            RuleFor(a => a.Password).Matches("^(?=.*[A-Z])(?=.*[!#@$%&])(?=.*[0-9])(?=.*[a-z]).{6,15}$").WithMessage("Senha muito fraca.");
            RuleFor(a => a.Password).MaximumLength(60).WithMessage("Campo deve conter no máximo 60 caracteres.");

        }
    }
}

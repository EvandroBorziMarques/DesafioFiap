using Dominio.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Validator
{
    public class TurmaValidator : AbstractValidator<Turma>
    {
        public TurmaValidator()
        {
            RuleFor(t => t.CourseId).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(t => t.CourseId).NotNull().WithMessage("Campo Obrigatório");

            RuleFor(t => t.Class).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(t => t.Class).NotNull().WithMessage("Campo Obrigatório");
            RuleFor(t => t.Class).MaximumLength(45).WithMessage("Campo deve conter no máximo 45 caracteres.");

            RuleFor(t => t.Year).NotEmpty().WithMessage("Campo Obrigatório");
            RuleFor(t => t.Year).NotEmpty().WithMessage("Campo Obrigatório");
        }           
    }
}

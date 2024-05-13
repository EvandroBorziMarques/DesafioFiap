using Microsoft.Extensions.DependencyInjection;
using Dominio.Interfaces;
using Infra.Repositorios.Base;
using Infra.Business;
using Infra.Repositorios.RepositorioAluno;
using Infra.Repositorios.RepositorioTurma;
using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Validator;
using FluentValidation;

namespace Infra.IoC
{
    public static class DependecyResolver
    {
        public static void RegisterRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IAluno, AlunoBusiness>();
            services.AddScoped<ITurma, TurmaBusiness>();
            services.AddScoped<IRepositorioBase, RepositorioBase>();
            services.AddScoped<IRepositorioAluno, RepositorioAluno>();
            services.AddScoped<IRepositorioTurma, RepositorioTurma>();
            services.AddTransient<IValidator<Aluno>, AlunoValidator>();
            services.AddTransient<IValidator<AlunoDTO>, AlunoDTOValidator>();
            services.AddTransient<IValidator<Turma>, TurmaValidator>();
            services.AddTransient<IValidator<TurmaDTO>, TurmaDTOValidator>();
        }
    }
}

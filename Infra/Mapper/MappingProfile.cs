using AutoMapper;
using Dominio.DTO;
using Dominio.Entidades;

namespace Infra.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Aluno, AlunoDTO>().ReverseMap();
            CreateMap<Turma, TurmaDTO>().ReverseMap();
        }
    }
}

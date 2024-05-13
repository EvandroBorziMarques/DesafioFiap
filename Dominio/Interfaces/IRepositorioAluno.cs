using Dominio.DTO;
using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IRepositorioAluno
    {
        public bool AlunoCreate(AlunoDTO alunoDTO);
        public Aluno AlunoGetById(int id);
        public List<Aluno> AlunoList();
        public bool AlunoUpdate(Aluno aluno);
        public bool AlunoDelete(int id);
    }
}

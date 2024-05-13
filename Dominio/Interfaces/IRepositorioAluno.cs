using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IRepositorioAluno
    {
        public bool AlunoCreate(Aluno aluno);
        public Aluno AlunoGetById(int id);
        public List<Aluno> AlunoList();
        public bool AlunoUpdate(Aluno aluno);
        public bool AlunoDelete(int id);
    }
}

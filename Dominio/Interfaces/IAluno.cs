using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IAluno
    {
        bool AlunoCreate(Aluno aluno);
        List<Aluno> AlunoList();
        Aluno AlunoGetById(int id);
        bool AlunoUpdate(Aluno aluno);
        bool AlunoDelete(int id);
    }
}

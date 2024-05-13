using Dominio.DTO;
using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IAluno
    {
        bool AlunoCreate(AlunoDTO alunoDTO);
        List<Aluno> AlunoList();
        Aluno AlunoGetById(int id);
        bool AlunoUpdate(Aluno aluno);
        bool AlunoDelete(int id);
    }
}

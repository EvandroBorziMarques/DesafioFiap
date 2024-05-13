using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IAlunoTurma
    {
        bool AlunoTurmaCreate(AlunoTurma alunoTurma);
        bool AlunoTurmaDelete(int studentId, int classId);
    }
}

using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IRepositorioAlunoTurma
    {
        public bool AlunoTurmaCreate(AlunoTurma alunoTurma);
        public bool AlunoTurmaDelete(int studentId, int classId);
    }
}

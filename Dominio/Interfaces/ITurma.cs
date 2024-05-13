using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface ITurma
    {
        bool TurmaCreate(Turma turma);
        List<Turma> TurmaList();
        Turma TurmaGetById(int id);
        bool TurmaUpdate(Turma turma);
        bool TurmaDelete(int id);
    }
}

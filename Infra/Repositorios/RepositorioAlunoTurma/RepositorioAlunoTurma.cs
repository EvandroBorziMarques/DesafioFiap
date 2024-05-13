using Dapper;
using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Infra.Repositorios.RepositorioAlunoTurma
{
    public class RepositorioAlunoTurma : IRepositorioAlunoTurma
    {
        private readonly IRepositorioBase _repositorioBase;

        public RepositorioAlunoTurma(IRepositorioBase repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }
        public bool AlunoTurmaCreate(AlunoTurma alunoTurma)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("StudentId", alunoTurma.StudentId);
            parameters.Add("ClassId", alunoTurma.ClassId);

            return _repositorioBase.Execute("AlunoTurmaCreate", parameters);
        }
        public bool AlunoTurmaDelete(int studentId, int classId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("studentId", studentId);
            parameters.Add("classId", classId);

            return _repositorioBase.Execute("AlunoTurmaDelete", parameters);
        }
    }
}

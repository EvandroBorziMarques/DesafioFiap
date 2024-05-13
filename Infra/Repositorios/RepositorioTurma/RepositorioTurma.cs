using Dapper;
using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Infra.Repositorios.RepositorioTurma
{
    public class RepositorioTurma : IRepositorioTurma
    {
        private readonly IRepositorioBase _repositorioBase;

        public RepositorioTurma(IRepositorioBase repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public bool TurmaCreate(TurmaDTO turmaDTO)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("CourseId", turmaDTO.CourseId);
            parameters.Add("Class", turmaDTO.Class);
            parameters.Add("Year", turmaDTO.Year);

            return _repositorioBase.Execute("TurmaCreate", parameters);
        }
        public Turma TurmaGetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", id);

            return _repositorioBase.QueryFirst<Turma>("TurmaGetById", parameters);
        }
        public List<Turma> TurmaList()
        {
            DynamicParameters parameters = new DynamicParameters();
            return _repositorioBase.Query<Turma>("TurmaList", parameters);
        }
        public bool TurmaUpdate(Turma turma)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", turma.ID);
            parameters.Add("CourseId", turma.CourseId);
            parameters.Add("Class", turma.Class);
            parameters.Add("Year", turma.Year);

            return _repositorioBase.Execute("TurmaUpdate", parameters);
        }
        public bool TurmaDelete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", id);

            return _repositorioBase.Execute("TurmaDelete", parameters);
        }
        public int TurmaVerify(string turma)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("class", turma);
            return _repositorioBase.QueryFirst<int>("TurmaVerify", parameters); ;
        }
    }
}

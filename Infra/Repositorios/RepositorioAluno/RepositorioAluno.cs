using Dapper;
using Dominio.Entidades;
using Dominio.Interfaces;

namespace Infra.Repositorios.RepositorioAluno
{
    public class RepositorioAluno : IRepositorioAluno
    {
        private readonly IRepositorioBase _repositorioBase;

        public RepositorioAluno(IRepositorioBase repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public bool AlunoCreate(Aluno aluno)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", aluno.ID);
            parameters.Add("Name", aluno.Name);
            parameters.Add("User", aluno.User);
            parameters.Add("Password", aluno.Password);

            return _repositorioBase.Execute("AlunoCreate", parameters);
        }
        public Aluno AlunoGetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", id);

            return _repositorioBase.QueryFirst<Aluno>("AlunoGetById", parameters);
        }

        public List<Aluno> AlunoList()
        {
            DynamicParameters parameters = new DynamicParameters();
            return _repositorioBase.Query<Aluno>("AlunoList", parameters);
        }

        public bool AlunoUpdate(Aluno aluno)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ID", aluno.ID);
            parameters.Add("Name", aluno.Name);
            parameters.Add("User", aluno.User);
            parameters.Add("Password", aluno.Password);

            return _repositorioBase.Execute("AlunoUpdate", parameters);
        }

        public bool AlunoDelete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", id);

            return _repositorioBase.Execute("AlunoDelete", parameters);
        }
    }
}

using Dominio.Entidades;
using Dominio.Interfaces;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;

namespace Infra.Business
{
    public class AlunoBusiness : IAluno
    {
        private readonly IRepositorioAluno _repositorioAluno;

        public AlunoBusiness(IRepositorioAluno repositorioAluno)
        {
            _repositorioAluno = repositorioAluno;
        }

        public bool AlunoCreate(Aluno aluno)
        {
            aluno.Password = EncriptPassword(aluno.Password);
            bool response = _repositorioAluno.AlunoCreate(aluno);
            return response;
        }
        public List<Aluno> AlunoList()
        {
            List<Aluno> aluno = _repositorioAluno.AlunoList();
            return aluno;
        }
        public Aluno AlunoGetById(int id)
        {
            Aluno aluno = _repositorioAluno.AlunoGetById(id);
            return aluno;
        }
        public bool AlunoUpdate(Aluno aluno)
        {
            aluno.Password = EncriptPassword(aluno.Password);
            bool response= _repositorioAluno.AlunoUpdate(aluno);
            return response;
        }
        public bool AlunoDelete(int id)
        {
            bool response = _repositorioAluno.AlunoDelete(id);
            return response;
        }
        private string EncriptPassword(string password)
        {
            var md5 = MD5.Create();
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}

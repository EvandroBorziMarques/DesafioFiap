using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Business
{
    public class AlunoTurmaBusiness : IAlunoTurma
    {
        private readonly IRepositorioAlunoTurma _repositorioAlunoTurma;

        public AlunoTurmaBusiness(IRepositorioAlunoTurma repositorioAlunoTurma)
        {
            _repositorioAlunoTurma = repositorioAlunoTurma;
        }

        public bool AlunoTurmaCreate(AlunoTurma alunoTurma)
        {
            bool response = _repositorioAlunoTurma.AlunoTurmaCreate(alunoTurma);
            return response;
        }
        public bool AlunoTurmaDelete(int studentId, int classId)
        {
            bool response = _repositorioAlunoTurma.AlunoTurmaDelete(studentId, classId);
            return response;
        }
    }
}

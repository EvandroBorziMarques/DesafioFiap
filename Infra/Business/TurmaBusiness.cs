using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Business
{
    public class TurmaBusiness : ITurma
    {
        private readonly IRepositorioTurma _repositorioTurma;

        public TurmaBusiness(IRepositorioTurma repositorioTurma)
        {
            _repositorioTurma = repositorioTurma;
        }

        public bool TurmaCreate(Turma turma)
        {
            bool response = _repositorioTurma.TurmaCreate(turma);
            return response;
        }
        public List<Turma> TurmaList()
        {
            List<Turma> turma = _repositorioTurma.TurmaList();
            return turma;
        }
        public Turma TurmaGetById(int id)
        {
            Turma turma = _repositorioTurma.TurmaGetById(id);
            return turma;
        }
        public bool TurmaUpdate(Turma turma)
        {
            bool response = _repositorioTurma.TurmaUpdate(turma);
            return response;
        }
        public bool TurmaDelete(int id)
        {
            bool response = _repositorioTurma.TurmaDelete(id);
            return response;
        }
    }
}

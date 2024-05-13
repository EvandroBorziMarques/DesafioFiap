using Dominio.DTO;
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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

        public bool TurmaCreate(TurmaDTO turmaDTO)
        {
            if (!TurmaVerify(turmaDTO.Class))
                return false;
            bool response = _repositorioTurma.TurmaCreate(turmaDTO);
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
        private bool TurmaVerify(string turma)
        {
            bool response = _repositorioTurma.TurmaVerify(turma).Equals(0) ? true : false;
            return response;
        }
    }
}

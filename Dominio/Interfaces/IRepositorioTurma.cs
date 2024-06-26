﻿using Dominio.DTO;
using Dominio.Entidades;

namespace Dominio.Interfaces
{
    public interface IRepositorioTurma
    {
        public bool TurmaCreate(TurmaDTO turmaDTO);
        public Turma TurmaGetById(int id);
        public List<Turma> TurmaList();
        public bool TurmaUpdate(Turma turma);
        public bool TurmaDelete(int id);
        public int TurmaVerify(string turma);
    }
}

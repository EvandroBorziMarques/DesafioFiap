using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("aluno_turma")]
    public class AlunoTurma
    {
        [Column("aluno_id")]
        public int StudentId { get; set; }

        [Column("turma_id")]
        public int? ClassId { get; set; }
    }
}

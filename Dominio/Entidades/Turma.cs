using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Turma")]
    public class Turma
    {
        [Column("Id")]
        public int ID { get; set; }

        [Column("Curso_Id")]
        public int? CourseId { get; set; }

        [Column("Turma")]
        public string? Class { get; set; }

        [Column("Ano")]
        public int? Year { get; set; }
    }
}

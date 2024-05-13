using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id")]
        public int ID { get; set; }

        [Column("Nome")]
        public string? Name { get; set; }

        [Column("Usuario")]
        public string? User { get; set; }

        [Column("Senha")]
        public string? Password { get; set; }
    }
}

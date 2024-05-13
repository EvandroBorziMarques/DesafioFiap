using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTO
{
    public class TurmaDTO
    {
        public int ID { get; set; }

        public int CourseId { get; set; }

        public string Class { get; set; }

        public int Year { get; set; }
    }
}

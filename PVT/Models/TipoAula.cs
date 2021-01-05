using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Models
{
    [Table("PVT_TIPO_AULA")]
    public class TipoAula : Entity
    {
        public string VIDEO { get; set; }
        public string ARQUIVO { get; set; }
        public string TEXTO { get; set; }

        public IEnumerable<Aula> Aulas { get; set; }

    }
}

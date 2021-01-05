using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_TIPO_AULA")]
    public class TipoAula : Entity
    {
        public string VIDEO { get; set; }
        public string ARQUIVO { get; set; }
        public string TEXTO { get; set; }

        //public IEnumerable<Aula> Aulas { get; set; }

    }
}

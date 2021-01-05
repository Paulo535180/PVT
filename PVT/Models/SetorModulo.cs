using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Models
{
    [Table("PVT_SETOR_MODULO")]
    public class SetorModulo : Entity
    {
        public int ID_MODULO { get; set; }
        public int ID_SETOR { get; set; }
        public Modulo Modulo { get; set; }
        public Setor Setor { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_MODULO")]
    public class Modulo : Entity
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string NOME { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 3)]
        public string DESCRICAO { get; set; }
        public int ID_USUARIO_GESTOR { get; set; }
    }
}

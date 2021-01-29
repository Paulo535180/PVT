using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_SETOR_MODULO")]
    public class SetorModulo : Entity
    {
        public int ID_MODULO { get; set; }
        public int ID_SETOR { get; set; }
    }
}

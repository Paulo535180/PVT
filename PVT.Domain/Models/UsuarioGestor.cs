using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_USUARIO_GESTOR")]
    public class UsuarioGestor : Entity
    {
        public int ID_SETOR { get; set; }
        public int ID_USUARIO { get; set; }
        public string NOME_GESTOR { get; set; }
        //public Setor Setor { get; set; }
    }
}

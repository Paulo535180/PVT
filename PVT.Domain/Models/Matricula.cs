using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_MATRICULA")]
    public class Matricula : Entity
    {
        public int ID_ALUNO { get; set; }
        public int ID_MODULO { get; set; }
        public int ID_CURSO { get; set; }
        public int QTD_AULAS { get; set; }
    }
}

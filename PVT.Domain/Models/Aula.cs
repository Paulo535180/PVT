using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_AULA")]
    public class Aula : Entity
    {
        public int ID_TIPO_AULA { get; set; }
        public int ID_DISCIPLINA { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string NOME { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 3)]
        public string DESCRICAO { get; set; }

        [Required]
        public int ORDEM_AULA { get; set; }

        //----- Aqui eu digo que a minha Aula tem um tipo de aula -----//
        //public TipoAula TipoAula { get; set; }

        //----- Aqui eu digo que meu modelo de Aula pertence a uma disciplina -----//
        //public Disciplina Disciplina { get; set; }
    }
}

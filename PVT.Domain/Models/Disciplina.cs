using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PVT.Domain.Models
{
    [Table("PVT_DISCIPLINA")]
    public class Disciplina : Entity
    {
        public int ID_CURSO { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string NOME { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 3)]
        public string DESCRICAO { get; set; }

        [Required]
        public int PRIORIDADE { get; set; }

        //----- Aqui eu digo que Disciplina tem uma lista de Aulas -----//
        //public IEnumerable<Aula> Aulas { get; set; }

        //----- aqui eu digo que minha disciplina tem q pertencer a um curso -----//
        //public Curso Curso { get; set; }
    }
}

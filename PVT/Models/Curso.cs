using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Models
{
    [Table("PVT_CURSO")]
    public class Curso : Entity
    {
        public int ID_MODULO { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string NOME { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 3)]
        public string DESCRICAO { get; set; }

        [Required]
        public int PRIORIDADE { get; set; }


        //-----Aqui eu digo que meu modelo de curso tem uma Lista de Disciplinas-----//
        public IEnumerable<Disciplina> Disciplinas { get; set; }

        //-----Aqui eu digo que meu modelo Curso está atrelado a um Modulo-----//
        public Modulo Modulo { get; set; }
    }
}

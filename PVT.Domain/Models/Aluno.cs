using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PVT.Domain.Models
{
    [Table("PVT_ALUNO")]
    public class Aluno : Entity
    {
        [Required]
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }
    }
}

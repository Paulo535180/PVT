using System;
using System.ComponentModel.DataAnnotations;

namespace PVT.Domain.Models
{
    public abstract class Entity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime DATA_CRIACAO { get; set; }

        [Required]
        public string USUARIO_CRIACAO { get; set; }

        public DateTime? DATA_ALTERACAO { get; set; }
        public string USUARIO_ALTERACAO { get; set; }

        [Required]
        public bool STATUS { get; set; }
    }
}

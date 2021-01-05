using System.ComponentModel.DataAnnotations;

namespace PVT.Domain.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe um nome para login no sistema")]
        public string Login { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma senha Válida")]
        public string Password { get; set; }
        public string Perfil { get; set; }
    }
}
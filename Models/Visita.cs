using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PC_4.Models
{
    public class Visita
    {
        public int ID {get; set;}
        [Required]
        public string Mensaje {get; set;}

        public ICollection<Usuario> Usuarios { get; set;}
    }
}
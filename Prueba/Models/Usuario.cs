using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace PC_4.Models
{
    public class Usuario
    {
        [Required]
        public int ID {get; set;}
        [Required]
        public string Nombre {get; set;}
        [Required]
        [Display (Name ="Nombre de la Foto")]
        public string NombreFoto {get; set;}
        
        [Required]
        public string Foto {get; set;}

        public DateTime FechaRegistro {get; set;}
        
        public Visita Visita {get; set;}
         public int VisitaID {get; set;}

         public Usuario(){
             FechaRegistro = DateTime.Now;
         }

    }
}
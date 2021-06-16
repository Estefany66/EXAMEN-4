using Microsoft.EntityFrameworkCore;
using EXAMEN_4.Models;

namespace EXAMEN_4.Models
{
    public class PeruFailContext: DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Visita> Visitas {get; set;}
   
   public PeruFailContext(DbContextOptions dco) : base(dco){
       
   }
   }
}
using Microsoft.AspNetCore.Mvc;
using EXAMEN_4.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using PC_4.Models;

namespace EXAMEN_4.Controllers
{
    public class UsuarioController : Controller
    {
       
        private readonly PeruFailContext _context;
        public UsuarioController(PeruFailContext context)
        {
           _context = context;
        }

        public IActionResult Registro(){
            ViewBag.Visitas = _context.Visitas.Select(x => new SelectListItem(x.Mensaje, x.ID.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario p){
            if(ModelState.IsValid){
                _context.Usuarios.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");

            }else{
                return View(p);
            }
        }
    }
}
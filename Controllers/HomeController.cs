﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EXAMEN_4.Models;

namespace EXAMEN_4.Controllers
{
    public class HomeController : Controller
    {
       private readonly PeruFailContext _context;
        public HomeController(PeruFailContext context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
            var usuarios = _context.Usuarios.Include(x => x.Invitado)
                        .Where(x => x.FechaRegistro.AddDays(5) >= DateTime.Now)
                        .ToList();
            return View(usuarios);
        }

        public IActionResult Login()
        {
            return View();
        }

         public IActionResult Register()
        {
            return View();
        }

         public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

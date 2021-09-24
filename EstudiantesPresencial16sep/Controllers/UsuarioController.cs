using EstudiantesPresencial16sep.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudiantesPresencial16sep.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }
            else
            {
                //return View("Index", usuario);
                return Redirect("Usuario/Error");
            }
        }

        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}

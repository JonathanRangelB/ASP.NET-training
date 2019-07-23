using System;
using Fundamentos_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fundamentos_ASP.NetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";

            ViewBag.CualquierCosa = "Valor cualquiera";
            return View(escuela);
        }
    }
}
using System;
using Fundamentos_ASP.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fundamentos_ASP.NetCore.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela =  new Escuela();
            escuela.AñoFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";

            ViewBag.CualquierCosa = "Valor cualquiera";
            return View(escuela);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net.Models;

namespace net.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;

        public PersonaController(ILogger<PersonaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecibirDatosPersona(string nombre, int edad, bool jubilado) {

            ViewBag.nombre=nombre;
            ViewBag.edad=edad;
            ViewBag.jubilado=jubilado;
            return View();
        }

         public IActionResult FormularioPersona()
        {
            return View();
        }

        
    }
}

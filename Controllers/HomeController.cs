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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Formulario()
        {
            return View();
        }
         public IActionResult VerNota( int nota)

        {
            //el viewbag como su nombre indica
            //es una bolsa de intercambio de informacion
            //entre el controlador y la vista
            ViewBag.nota=nota;
            return View();
        }
        
        public IActionResult Mensaje()
        {   ViewBag.Mensaje="mensaje de cecilio";
            return View();
        }


         public IActionResult ciennumeros()
        {   
            return View();
        }
         public IActionResult FormularioSuma()
        {   
            return View();
        }
         public IActionResult ResultadoSuma(int numero1,int numero2)
        {   
            int suma= numero1+numero2;
            ViewBag.suma=suma;
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

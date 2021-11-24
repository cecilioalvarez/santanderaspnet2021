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
    public class FacturaController : Controller
    {

        public FacturaController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecibirDatosFactura(Factura factura) {

            ViewBag.Numero=factura.Numero;
            ViewBag.Concepto=factura.Concepto;
            ViewBag.Importe=factura.Importe;
            return View();
        }

         public IActionResult FormularioFactura()
        {
            return View();
        }

        
    }
}

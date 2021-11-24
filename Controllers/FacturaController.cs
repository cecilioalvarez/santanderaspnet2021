using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net.Models;
using net.Models.Repositorios;

namespace net.Controllers
{
    public class FacturaController : Controller
    {

        public FacturaController()
        {

        }

        public IActionResult Index()
        {
            ViewBag.ListaFacturas = FacturaRepositorio.Lista;
            return View();
        }


        public IActionResult Insertar(Factura factura)
        {
            // yo inserto y despues de insertar
            // vuelto a mostrar el listado
            FacturaRepositorio.Insertar(factura);
            ViewBag.ListaFacturas = FacturaRepositorio.Lista;
            return View("Index");
        }
        public IActionResult Detalle(int numero)
        {
            
            ViewBag.Numero = numero;
            /*
            ViewBag.Concepto = factura.Concepto;
            ViewBag.Importe = factura.Importe;
            ViewBag.TipoIVA = factura.TipoIVA;
            ViewBag.Pagada = factura.Pagada;
            */
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        /*
        public IActionResult ListaFacturas()
        {
            ViewBag.ListaFacturas=FacturaRepositorio.Lista;
            return View();
        }
*/

    }
}

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
            ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return View();
        }


        public IActionResult Insertar(Factura factura)
        {
            // yo inserto y despues de insertar
            // vuelto a mostrar el listado
            FacturaRepositorio.Insertar(factura);

            return RedirectToAction("Index", "Factura");
        }
        public IActionResult Detalle(int numero)
        {

            ViewBag.Factura = FacturaRepositorio.BuscarUna(numero);

            /*
            ViewBag.Concepto = factura.Concepto;
            ViewBag.Importe = factura.Importe;
            ViewBag.TipoIVA = factura.TipoIVA;
            ViewBag.Pagada = factura.Pagada;
            */
            return View();
        }

        public IActionResult Borrar(int numero)
        {

            FacturaRepositorio.Borrar(numero);

            //ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();

            return RedirectToAction("Index", "Factura");
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

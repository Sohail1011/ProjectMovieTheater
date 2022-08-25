using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// importar al modelo/s
using ProyectoCine.Models;

namespace ProyectoCine.Controllers
{
    public class ENTRADASController : Controller
    {
        static List<ENTRADAS> Lista = new List<ENTRADAS>();

        List<string> Horarios = new List<string>()
        { "16:00","18:00", "20:00","22:00"};

        // GET: ENTRADASController
        public ActionResult IndexEntradas() // Listado
        {
            // enviar los datos del modelo a la vista
            return View(Lista);
        }

        // GET: ENTRADASController/Details/5
        public ActionResult DetailsEntradas(int id) // Consulta de 1
        {
            return View();
        }

        // GET: ENTRADASController/Create
        public ActionResult CreateEntradas() // Grabar
        {
            // creamos una nueva instancia del modelo ENTRADAS
            ENTRADAS obj = new ENTRADAS();
            obj.FechaEntrada = DateTime.Today;
            obj.Cantidad = 1;

            // enviamos el nuevo modelo a la vista
            return View(obj);
        }

        // POST: ENTRADASController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEntradas(ENTRADAS xEnt) // Grabar
        {
            // agregar la variable del objeto ENTRADAS a la lista
            Lista.Add(xEnt);

            // enviando un mensaje a la vista
            // creando la variable
            ViewBag.MENSAJE = "Nueva Entrada grabada correctamente";

            return View(xEnt);
        }

        // GET: ENTRADASController/Edit/5
        public ActionResult EditEntradas(int id)
        {
            return View();
        }

        // POST: ENTRADASController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEntradas(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ENTRADASController/Delete/5
        public ActionResult DeleteEntradas(int id)
        {
            return View();
        }

        // POST: ENTRADASController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEntradas(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

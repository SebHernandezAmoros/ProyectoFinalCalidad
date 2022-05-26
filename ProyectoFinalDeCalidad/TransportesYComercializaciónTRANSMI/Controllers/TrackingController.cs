using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Controllers
{
    public class TrackingController : Controller
    {
        private DbEntities dbEntities;
        public TrackingController(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }

        public IActionResult Index()
        {
            List<Paquete> paquetes = dbEntities.Paquetes.ToList();

            return View(paquetes);
        }

        [HttpGet]
        public IActionResult SearchTracking(int idPaquete)
        {
            var paqueteEmpleados = dbEntities.PaqueteEmpleados.Where(o =>o.IdPaquete==idPaquete).ToList();
            ViewBag.Package = dbEntities.Paquetes.FirstOrDefault(o => o.PaqueteId == idPaquete);
            ViewBag.Actors = dbEntities.PaqueteClientes
                .Include(o=>o.Clientë)
                .Where(o => o.IdPaquete == idPaquete).ToList();

            if (ViewBag.Package == null)
            {
                ModelState.AddModelError("IdInvalid", "El ID ingresado no es valido...");
                return View("Index");
            }
            return View(paqueteEmpleados);
        }


        [HttpGet]
        public IActionResult CreatePackage()
        {


            return View(new Paquete());
        }
        [HttpPost]
        public IActionResult CreatePackage(Paquete paquete)
        {

            //Confirmar si los datos has sido bien ingresados
            if (paquete.Contenido == null || paquete.Contenido == "")
            {
                ModelState.AddModelError("Contenido", "El contenido es obligatorio");
            }
            if (paquete.Peso == 0 || paquete.Peso < 0)
            {
                ModelState.AddModelError("Peso", "El peso debe ser mayor que 0");
            }
            if (paquete.DimensionX == 0 || paquete.DimensionX < 0)
            {
                ModelState.AddModelError("DimensionX", "La medida debe ser mayor que 0");
            }
            if (paquete.DimensionY == 0 || paquete.DimensionY < 0)
            {
                ModelState.AddModelError("DimensionY", "La medida debe ser mayor que 0");
            }
            if (paquete.DimensionZ == 0 || paquete.DimensionZ < 0)
            {
                ModelState.AddModelError("DimensionZ", "La medida debe ser mayor que 0");
            }
            if (paquete.CiudadOrigen == paquete.CiudadMeta)
            {
                ModelState.AddModelError("Ciudad", "La ciudad de origen y meta no pueden ser las mismas");
            }
            if (paquete.PrecioEnvio == 0 || paquete.DimensionZ < 0)
            {
                ModelState.AddModelError("Precio", "El precio negociado debe ser mayor que 0");
            }


            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Pagado", "No olvides volver a marcar la casilla, si ese es el caso");

                return View("CreatePackage", paquete);
            }
            dbEntities.Paquetes.Add(paquete);
            dbEntities.SaveChanges();
            //Redirigir al formulario para ingresar a los clientes y al empleado que registraron el paquete

            //Obtener datos del ultimo registro
            //https://stackoverflow.com/questions/34312665/how-to-get-id-of-last-savednot-recently-saved-row-in-asp-net-mvc

            //Enviar dato del ultimo paquete registrado via viewbag
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            var paqueteEmpleados = dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == idPaquete).ToList();
            ViewBag.Package = dbEntities.Paquetes.FirstOrDefault(o => o.PaqueteId == idPaquete);
            ViewBag.Actors = dbEntities.PaqueteClientes
                .Include(o => o.Clientë)
                .Where(o => o.IdPaquete == idPaquete).ToList();

            if (ViewBag.Package == null)
            {
                ModelState.AddModelError("IdInvalid", "El ID ingresado no es valido...");
                return View("Index");
            }
            return View(paqueteEmpleados);
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreatePackage()
        {
            //ViewBag.User = GetLoggedUser().Usuario;

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



            //Enviar dato del ultimo paquete registrado via viewbag
            return RedirectToAction("CreateActors");
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateActors()
        {
            Paquete paquete = dbEntities.Paquetes.OrderByDescending(o => o.PaqueteId).First();
            ViewBag.LastPackage = paquete.PaqueteId;
            List<Cliente> Actors = new()
            {
                new Cliente {},
                new Cliente {}
            };

            return View(Actors);
        }

        [HttpPost]
        public IActionResult CreateActors(List<Cliente> Actors)
        {
            Paquete paquete = dbEntities.Paquetes.OrderByDescending(o => o.PaqueteId).First();
            //Si el dni de uno o los 2 ya esta registrado que retorne
            //los datos llenos y
            //ya no ejecute la funcion add a cliente
            if (Actors.Count == 0)
            {
                ModelState.AddModelError("Vacio", "La lista esta vacia");
            }
            foreach (var actor in Actors)
            {
                if (actor.Nombre == null || actor.Nombre == "")
                {
                    ModelState.AddModelError("Nombre", "Falto el Ingreso del nombre del emisor o el receptor");
                }
                if (actor.Apellido == null || actor.Apellido == "")
                {
                    ModelState.AddModelError("Apellido", "Falto el Ingreso del apellido del emisor o el receptor");
                }
            }
            if (!ModelState.IsValid)
            {
                if (Actors[0].Dni != null || Actors[1].Dni != null)
                {
                    Actors = GetClientes(Actors);
                }
                ViewBag.LastPackage = paquete.PaqueteId;
                return View("CreateActors", Actors);
            }
            
            if (SearchCliente(Actors[0])==null)
            {
                dbEntities.Clientes.Add(Actors[0]);
                dbEntities.SaveChanges();
            }
            if (SearchCliente(Actors[1]) == null)
            {
                dbEntities.Clientes.Add(Actors[1]);
                dbEntities.SaveChanges();
            }
            //Crear un registro paqueteempleado Con la fecha actual el
            //id de paquete, empleado y su estado
            PaqueteEmpleado PeIngreso = new PaqueteEmpleado { 
                IdPaquete = paquete.PaqueteId, 
                Estado="Recepcionado", 
                FechaActualizacion= DateTime.Now, 
                CiudadActual=paquete.CiudadOrigen, 
                IdEmpleado=GetLoggedUser().EmpleadoId
            };
            dbEntities.PaqueteEmpleados.Add(PeIngreso);
            dbEntities.SaveChanges();

            //Crear dos registro paquetecliente con el id del paquete y
            //los id de actors
            PaqueteCliente PcEmisor = new PaqueteCliente { Rol="Emisor", IdPaquete=paquete.PaqueteId,IdCliente = dbEntities.Clientes.FirstOrDefault(o => o.Dni == Actors[0].Dni).ClienteId};
            PaqueteCliente PcReceptor = new PaqueteCliente { Rol = "Receptor", IdPaquete = paquete.PaqueteId, IdCliente = dbEntities.Clientes.FirstOrDefault(o => o.Dni == Actors[1].Dni).ClienteId };
            dbEntities.PaqueteClientes.Add(PcEmisor);
            dbEntities.PaqueteClientes.Add(PcReceptor);
            dbEntities.SaveChanges();

            return View("Index");
        }

        [Authorize]
        [HttpGet]
        public IActionResult ViewPackages(int IdPaquete) 
        {
            //Enviar lista de paquetes que esten en la misma ciudad que el logueado
            List<Paquete> paquetes= null;
            if (IdPaquete == 0)
            {
                paquetes = dbEntities.Paquetes.ToList();
            }
            else
            {
                paquetes = dbEntities.Paquetes.Where(o => o.PaqueteId == IdPaquete).ToList();
            }

            ViewBag.Aux = 0;
            return View(paquetes);
        }
        //Crear una segunda vista donde llegue el paque seleccionado anteriomente e ingresar ciudad, el estado y el ID del paquete
        //Al finalizar el ingreso retorna a la tabla

        [Authorize]
        [HttpGet]
        public IActionResult UpdatePackage(int ID)
        {
            ViewBag.IdPackage = ID;
            ViewBag.Lista = dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == ID).ToList();

            return View(new PaqueteEmpleado());
        }
        [HttpPost]
        public IActionResult UpdatePackage(PaqueteEmpleado paqueteEmpleado)
        {
            if (paqueteEmpleado.Estado == null || paqueteEmpleado.Estado == "Elige")
            {
                ModelState.AddModelError("Error", "Falto algun parametro vuelve a intentarlo");
            }
            if (paqueteEmpleado.CiudadActual == null || paqueteEmpleado.CiudadActual == "Elige")
            {
                ModelState.AddModelError("Error", "Falto algun parametro vuelve a intentarlo");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.IdPackage = paqueteEmpleado.IdPaquete;
                ViewBag.Lista = dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == paqueteEmpleado.IdPaquete).ToList();
                return View("UpdatePackage", paqueteEmpleado.IdPaquete);
            }
            paqueteEmpleado.IdEmpleado = GetLoggedUser().EmpleadoId;
            paqueteEmpleado.FechaActualizacion = DateTime.Now;
            dbEntities.PaqueteEmpleados.Add(paqueteEmpleado);
            dbEntities.SaveChanges();

            return RedirectToAction("ViewPackages",0);
        }


        private List<Cliente> GetClientes(List<Cliente> Actors)
        {
            Cliente Emisor = Actors[0];
            Cliente Receptor = Actors[1];
            Emisor = SearchCliente(Emisor);
            if (Emisor != null)
            {
                Actors[0] = Emisor;
                ModelState.AddModelError("EmisorSearch", "El emisor esta registrado");
            }
            Receptor = SearchCliente(Receptor);
            if (Receptor != null)
            {
                Actors[1] = Receptor;
                ModelState.AddModelError("ReceptorSearch", "El receptor esta registrado");
            }
            return Actors;
        }

        private Cliente SearchCliente(Cliente cliente)
        {
            Cliente actor = dbEntities.Clientes.FirstOrDefault(o => o.Dni == cliente.Dni);
            if (actor == null)
            {
                return null;
            }
            return actor;
        }

        //Retorna el usuario con el que te logueas!
        private Empleado GetLoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name);
            var username = claim.Value;
            return dbEntities.Empleados.FirstOrDefault(o => o.Usuario == username);
        }
    }
}

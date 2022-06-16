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
using TransportesYComercializaciónTRANSMI.Repositories;

namespace TransportesYComercializaciónTRANSMI.Controllers
{
    public class TrackingController : Controller
    {
        private DbEntities dbEntities;
        private readonly IClienteRepositorio clienteRepositorio;
        private readonly IEmpleadoRepositorio empleadoRepositorio;
        private readonly IPaqueteRepositorio paqueteRepositorio;
        private readonly IPaqueteClienteRepositorio paqueteClienteRepositorio;
        private readonly IPaqueteEmpleadoRepositorio paqueteEmpleadoRepositorio;
        public TrackingController(IClienteRepositorio clienteRepositorio, IEmpleadoRepositorio empleadoRepositorio, IPaqueteRepositorio paqueteRepositorio, IPaqueteClienteRepositorio paqueteClienteRepositorio, IPaqueteEmpleadoRepositorio paqueteEmpleadoRepositorio, DbEntities dbEntities)
        {
            this.clienteRepositorio = clienteRepositorio;
            this.empleadoRepositorio = empleadoRepositorio;
            this.paqueteRepositorio = paqueteRepositorio;
            this.paqueteClienteRepositorio = paqueteClienteRepositorio;
            this.paqueteEmpleadoRepositorio = paqueteEmpleadoRepositorio;
            this.dbEntities = dbEntities;
        }

        public IActionResult Index()
        {
            List<Paquete> paquetes = paqueteRepositorio.ObtenerTodos();
            //List <Paquete> paquetes = dbEntities.Paquetes.ToList();

            return View(paquetes);
        }

        [HttpGet]
        public IActionResult SearchTracking(int idPaquete)
        {
            var paqueteEmpleados = paqueteEmpleadoRepositorio.ObtenerPorIdPaquete(idPaquete);

            //ViewBag.Package = dbEntities.Paquetes.FirstOrDefault(o => o.PaqueteId == idPaquete);
            ViewBag.Package = paqueteRepositorio.ObtenerPorId(idPaquete);
            ViewBag.Actors = paqueteClienteRepositorio.ObtenerActors(idPaquete);
            //ViewBag.Actors = dbEntities.PaqueteClientes
            //    .Include(o => o.Clientë)
            //    .Where(o => o.IdPaquete == idPaquete).ToList();

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
            //dbEntities.Paquetes.Add(paquete);
            //dbEntities.SaveChanges();
            paqueteRepositorio.Guardar(paquete);



            return RedirectToAction("CreateActors");
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateActors()
        {
            //Paquete paquete = dbEntities.Paquetes.OrderByDescending(o => o.PaqueteId).First();
            Paquete paquete = paqueteRepositorio.ObtenerUltimo();
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
            //Paquete paquete = dbEntities.Paquetes.OrderByDescending(o => o.PaqueteId).First();
            Paquete paquete = paqueteRepositorio.ObtenerUltimo();

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
                //dbEntities.Clientes.Add(Actors[0]);
                //dbEntities.SaveChanges();
                clienteRepositorio.Guardar(Actors[0]);
            }
            if (SearchCliente(Actors[1]) == null)
            {
                //dbEntities.Clientes.Add(Actors[1]);
                //dbEntities.SaveChanges();
                clienteRepositorio.Guardar(Actors[1]);
            }

            PaqueteEmpleado PeIngreso = new PaqueteEmpleado { 
                IdPaquete = paquete.PaqueteId, 
                Estado="Recepcionado", 
                FechaActualizacion= DateTime.Now, 
                CiudadActual=paquete.CiudadOrigen, 
                IdEmpleado=GetLoggedUser().EmpleadoId
            };
            //dbEntities.PaqueteEmpleados.Add(PeIngreso);
            //dbEntities.SaveChanges();
            paqueteEmpleadoRepositorio.Guardar(PeIngreso);


            PaqueteCliente PcEmisor = new PaqueteCliente { Rol="Emisor", IdPaquete=paquete.PaqueteId,IdCliente = clienteRepositorio.ObtenerPorDni(Actors[0].Dni).ClienteId};
            PaqueteCliente PcReceptor = new PaqueteCliente { Rol = "Receptor", IdPaquete = paquete.PaqueteId, IdCliente = clienteRepositorio.ObtenerPorDni(Actors[1].Dni).ClienteId };
            //dbEntities.PaqueteClientes.Add(PcEmisor);
            //dbEntities.PaqueteClientes.Add(PcReceptor);
            //dbEntities.SaveChanges();
            paqueteClienteRepositorio.Guardar(PcEmisor);
            paqueteClienteRepositorio.Guardar(PcReceptor);

            return View("Index");
        }

        [Authorize]
        [HttpGet]
        public IActionResult ViewPackages(int IdPaquete) 
        {
            List<Paquete> paquetes= null;
            if (IdPaquete == 0)
            {
                //paquetes = dbEntities.Paquetes.ToList();
                paquetes = paqueteRepositorio.ObtenerTodos();
            }
            else
            {
                //paquetes = dbEntities.Paquetes.Where(o => o.PaqueteId == IdPaquete).ToList();
                paquetes = paqueteRepositorio.ObtenerListaPorId(IdPaquete);
            }

            ViewBag.Aux = 0;
            return View(paquetes);
        }


        [Authorize]
        [HttpGet]
        public IActionResult UpdatePackage(int ID)
        {
            ViewBag.IdPackage = ID;
            //ViewBag.Lista = dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == ID).ToList();
            ViewBag.Lista = paqueteEmpleadoRepositorio.ObtenerPorIdPaquete(ID);

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
                //ViewBag.Lista = dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == paqueteEmpleado.IdPaquete).ToList();
                ViewBag.Lista = paqueteEmpleadoRepositorio.ObtenerPorIdPaquete(paqueteEmpleado.IdPaquete);
                return View("UpdatePackage", paqueteEmpleado.IdPaquete);
            }
            paqueteEmpleado.IdEmpleado = GetLoggedUser().EmpleadoId;
            paqueteEmpleado.FechaActualizacion = DateTime.Now;
            //dbEntities.PaqueteEmpleados.Add(paqueteEmpleado);
            //dbEntities.SaveChanges();
            paqueteEmpleadoRepositorio.Guardar(paqueteEmpleado);

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
            //Cliente actor = dbEntities.Clientes.FirstOrDefault(o => o.Dni == cliente.Dni);
            Cliente actor = clienteRepositorio.ObtenerPorDni(cliente.Dni);

            if (actor == null)
            {
                return null;
            }
            return actor;
        }

        public Empleado GetLoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name);
            var username = claim.Value;
            return empleadoRepositorio.ObtenerPorUserName(username);
        }
    }
}

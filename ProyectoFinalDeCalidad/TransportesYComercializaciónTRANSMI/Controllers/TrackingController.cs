using Microsoft.AspNetCore.Mvc;
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportesYComercializaciónTRANSMI.Models
{
    public class PaqueteEmpleado
    {
        public int IdEmpleado { get; set; }
        public int IdPaquete { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }
        public string CiudadActual { get; set; }
    }
}

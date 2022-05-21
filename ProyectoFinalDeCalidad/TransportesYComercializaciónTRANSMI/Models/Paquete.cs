using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportesYComercializaciónTRANSMI.Models
{
    public class Paquete
    {
        public int PaqueteId { get; set; }
        public double Peso { get; set; }
        public double DimensionX { get; set; }
        public double DimensionY { get; set; }
        public double DimensionZ { get; set; }
        public string Contenido { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadMeta { get; set; }
        public double PrecioEnvio { get; set; }
        public bool Pagado { get; set; }
    }
}

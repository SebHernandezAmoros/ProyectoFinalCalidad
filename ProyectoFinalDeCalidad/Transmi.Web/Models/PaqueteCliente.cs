using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportesYComercializaciónTRANSMI.Models
{
    public class PaqueteCliente
    {
        public int IdPaquete { get; set; }
        public string Rol { get; set; }

        public int IdCliente { get; set; }
        public Cliente? Clientë { get; set; }
    }
}

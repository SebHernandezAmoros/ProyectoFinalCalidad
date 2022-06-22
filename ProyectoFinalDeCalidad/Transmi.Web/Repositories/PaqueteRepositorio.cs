using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Repositories
{
    public interface IPaqueteRepositorio
    {
        void Guardar(Paquete paquete);
        List<Paquete> ObtenerTodos();
        Paquete ObtenerPorId(int id);
        List<Paquete> ObtenerListaPorId(int id);
        Paquete ObtenerUltimo();
    }
    public class PaqueteRepositorio : IPaqueteRepositorio
    {
        private DbEntities dbEntities;
        public PaqueteRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public void Guardar(Paquete paquete)
        {
            dbEntities.Paquetes.Add(paquete);
            dbEntities.SaveChanges();
        }

        public List<Paquete> ObtenerListaPorId(int id)
        {
            return dbEntities.Paquetes.Where(o => o.PaqueteId == id).ToList();
        }

        public Paquete ObtenerPorId(int id)
        {
            return dbEntities.Paquetes.FirstOrDefault(o => o.PaqueteId == id);
        }

        public List<Paquete> ObtenerTodos()
        {
            return dbEntities.Paquetes.ToList();
        }

        public Paquete ObtenerUltimo()
        {
            return dbEntities.Paquetes.OrderByDescending(o => o.PaqueteId).First();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Repositories
{
    public interface IPaqueteEmpleadoRepositorio
    {
        void Guardar(PaqueteEmpleado paqueteEmpleado);
        List<PaqueteEmpleado> ObtenerTodos();
        List<PaqueteEmpleado> ObtenerPorIdPaquete(int id);
        List<PaqueteEmpleado> ObtenerPorIdEmpleado(int id);
    }
    public class PaqueteEmpleadoRepositorio : IPaqueteEmpleadoRepositorio
    {
        private DbEntities dbEntities;
        public PaqueteEmpleadoRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public void Guardar(PaqueteEmpleado paqueteEmpleado)
        {
            dbEntities.PaqueteEmpleados.Add(paqueteEmpleado);
            dbEntities.SaveChanges();
        }

        public List<PaqueteEmpleado> ObtenerPorIdPaquete(int id)
        {
            return dbEntities.PaqueteEmpleados.Where(o => o.IdPaquete == id).ToList();
        }

        public List<PaqueteEmpleado> ObtenerPorIdEmpleado(int id)
        {
            return dbEntities.PaqueteEmpleados.Where(o => o.IdEmpleado == id).ToList();
        }

        public List<PaqueteEmpleado> ObtenerTodos()
        {
            return dbEntities.PaqueteEmpleados.ToList();
        }
    }
}

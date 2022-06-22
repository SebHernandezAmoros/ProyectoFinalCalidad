using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Repositories
{
    public interface IPaqueteClienteRepositorio
    {
        void Guardar(PaqueteCliente paqueteCliente);
        List<PaqueteCliente> ObtenerTodos();
        List<PaqueteCliente> ObtenerActors(int id);
        List<PaqueteCliente> ObtenerPorIdPaquete(int id);
        List<PaqueteCliente> ObtenerPorIdCliente(int id);
    }
    public class PaqueteClienteRepositorio : IPaqueteClienteRepositorio
    {
        private DbEntities dbEntities;
        public PaqueteClienteRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public void Guardar(PaqueteCliente paqueteCliente)
        {
            dbEntities.PaqueteClientes.Add(paqueteCliente);
            dbEntities.SaveChanges();
        }

        public List<PaqueteCliente> ObtenerPorIdPaquete(int id)
        {
            return dbEntities.PaqueteClientes.Where(o => o.IdPaquete == id).ToList();
        }
        public List<PaqueteCliente> ObtenerPorIdCliente(int id)
        {
            return dbEntities.PaqueteClientes.Where(o => o.IdCliente == id).ToList();
        }

        public List<PaqueteCliente> ObtenerTodos()
        {
            return dbEntities.PaqueteClientes.ToList();
        }

        public List<PaqueteCliente> ObtenerActors(int id)
        {
            return dbEntities.PaqueteClientes
                .Include(o => o.Clientë)
                .Where(o => o.IdPaquete == id).ToList();
        }
    }
}

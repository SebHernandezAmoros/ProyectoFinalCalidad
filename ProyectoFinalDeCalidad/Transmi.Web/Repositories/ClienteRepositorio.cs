using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Repositories
{
    public interface IClienteRepositorio
    {
        void Guardar(Cliente cliente);
        List<Cliente> ObtenerTodos();
        Cliente ObtenerPorDni(string dni);
    }
    public class ClienteRepositorio:IClienteRepositorio
    {
        private readonly DbEntities dbEntities;
        public ClienteRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public void Guardar(Cliente cliente)
        {
            dbEntities.Clientes.Add(cliente);
            dbEntities.SaveChanges();
        }
        public List<Cliente> ObtenerTodos()
        {
            return dbEntities.Clientes.ToList();
        }
        public Cliente ObtenerPorDni(string dni)
        {
            return dbEntities.Clientes.FirstOrDefault(o => o.Dni == dni);
        }
    }
}

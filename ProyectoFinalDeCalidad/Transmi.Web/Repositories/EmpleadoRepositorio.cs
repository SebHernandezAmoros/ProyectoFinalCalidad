using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Repositories
{
    public interface IEmpleadoRepositorio
    {
        void Guardar(Empleado empleado);
        List<Empleado> ObtenerTodos();
        Empleado ObtenerPorId(int id);
        Empleado ObtenerPorUserName(string username);
    }
    public class EmpleadoRepositorio : IEmpleadoRepositorio
    {
        private DbEntities dbEntities;
        public EmpleadoRepositorio(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }
        public void Guardar(Empleado empleado)
        {
            dbEntities.Empleados.Add(empleado);
            dbEntities.SaveChanges();
        }

        public Empleado ObtenerPorId(int id)
        {
            return dbEntities.Empleados.FirstOrDefault(o => o.EmpleadoId == id);
        }

        public Empleado ObtenerPorUserName(string username)
        {
            return dbEntities.Empleados.FirstOrDefault(o => o.Usuario == username);
        }

        public List<Empleado> ObtenerTodos()
        {
            return dbEntities.Empleados.ToList();
        }
    }
}

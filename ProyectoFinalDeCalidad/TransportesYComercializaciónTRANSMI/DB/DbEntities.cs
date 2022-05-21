using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB.Mapping;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.DB
{
    public class DbEntities: DbContext
    {
        //DbSet
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Paquete> Paquetes { get; set; }
        public virtual DbSet<PaqueteCliente> PaqueteClientes { get; set; }
        public virtual DbSet<PaqueteEmpleado> PaqueteEmpleados { get; set; }
        //Constructors
        public DbEntities() { }
        public DbEntities(DbContextOptions<DbEntities> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new EmpleadoMapping());
            modelBuilder.ApplyConfiguration(new PaqueteClienteMapping());
            modelBuilder.ApplyConfiguration(new PaqueteEmpleadoMapping());
            modelBuilder.ApplyConfiguration(new PaqueteMapping());
        }

    }
}

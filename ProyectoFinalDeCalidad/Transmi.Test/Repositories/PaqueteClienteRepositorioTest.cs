using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;
using TransportesYComercializaciónTRANSMI.Repositories;

namespace Transmi.Test.Repositories
{
    class PaqueteClienteRepositorioTest
    {
        private IQueryable data;
        private PaqueteClienteRepositorio PaqueteClienterepo;
        [SetUp]
        public void Setup()
        { 
            data = new List<PaqueteCliente>
            {
                new PaqueteCliente { IdPaquete= 1,Rol="Emisor", IdCliente = 1 , 
                    Clientë= new Cliente{
                    ClienteId=1, Dni="45783612", Ruc="", Nombre="Seb", Apellido="Hernandez"} },
                new PaqueteCliente { IdPaquete= 1,Rol="Receptor", IdCliente = 2 ,
                    Clientë= new Cliente{
                    ClienteId=2, Dni="89455612", Ruc="", Nombre="Francis", Apellido="Arana"} }
            }.AsQueryable();
            var mockDbsetPaqueteCliente = new Mock<DbSet<PaqueteCliente>>();
            mockDbsetPaqueteCliente.As<IQueryable<PaqueteCliente>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetPaqueteCliente.As<IQueryable<PaqueteCliente>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetPaqueteCliente.As<IQueryable<PaqueteCliente>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetPaqueteCliente.As<IQueryable<PaqueteCliente>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<PaqueteCliente>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.PaqueteClientes).Returns(mockDbsetPaqueteCliente.Object);

            PaqueteClienterepo = new PaqueteClienteRepositorio(mockDB.Object);
        }
        [Test]
        public void ObtenerTodosTest()
        {
            var result = PaqueteClienterepo.ObtenerTodos();
            Assert.AreEqual(2, result.Count);
        }
        [Test]
        public void ObtenerPorIdPaqueteTest()
        {
            var result = PaqueteClienterepo.ObtenerPorIdPaquete(1);
            Assert.AreEqual("Seb", result[0].Clientë.Nombre);
        }
        [Test]
        public void ObtenerPorIdClienteTest()
        {
            var result = PaqueteClienterepo.ObtenerPorIdCliente(2);
            Assert.AreEqual(1, result[0].IdPaquete);
        }
    }
}

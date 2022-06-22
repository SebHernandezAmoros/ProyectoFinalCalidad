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
    class ClienteRepositorioTest
    {
        private IQueryable data;
        private ClienteRepositorio Clienterepo;
        [SetUp]
        public void Setup()
        {
            data = new List<Cliente>
            {
                new Cliente { ClienteId=1, Dni="45783612", Ruc="", Nombre="Seb", Apellido="Hernandez"},
                new Cliente { ClienteId=2, Dni="89564578", Ruc="", Nombre="Francis", Apellido="Paper"}
            }.AsQueryable();
            var mockDbsetCliente = new Mock<DbSet<Cliente>>();
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Cliente>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.Clientes).Returns(mockDbsetCliente.Object);

            Clienterepo = new ClienteRepositorio(mockDB.Object);
        }
        [Test]
        public void ObtenerTodosTest()
        {
            var result = Clienterepo.ObtenerTodos();
            Assert.AreEqual(2, result.Count());
        }
        [Test]
        public void ObtenerPorDniTest()
        {
            var result = Clienterepo.ObtenerPorDni("89564578");
            Assert.AreEqual("Francis", result.Nombre);
        }
    }
}

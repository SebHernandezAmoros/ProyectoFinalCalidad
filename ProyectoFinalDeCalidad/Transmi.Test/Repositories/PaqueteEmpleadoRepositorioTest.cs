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
    class PaqueteEmpleadoRepositorioTest
    {
        private IQueryable data;
        private PaqueteEmpleadoRepositorio PaqueteEmpleadorepo;
        [SetUp]
        public void Setup()
        {
            data = new List<PaqueteEmpleado>
            {
                new PaqueteEmpleado{ IdPaquete=1, IdEmpleado=3, CiudadActual="Lima",
                    Estado="Recepcionado", FechaActualizacion= new DateTime(2022, 5, 3,10,30,50)},
                new PaqueteEmpleado{ IdPaquete=1, IdEmpleado=4, CiudadActual="Lima",
                    Estado="Partio", FechaActualizacion= new DateTime(2022, 5, 3,12,30,50)},
                new PaqueteEmpleado{ IdPaquete=1, IdEmpleado=5, CiudadActual="Trujillo",
                    Estado="Arribo", FechaActualizacion= new DateTime(2022, 5, 4,8,30,50)}
            }.AsQueryable();
            var mockDbsetPaqueteEmpleado = new Mock<DbSet<PaqueteEmpleado>>();
            mockDbsetPaqueteEmpleado.As<IQueryable<PaqueteEmpleado>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetPaqueteEmpleado.As<IQueryable<PaqueteEmpleado>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetPaqueteEmpleado.As<IQueryable<PaqueteEmpleado>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetPaqueteEmpleado.As<IQueryable<PaqueteEmpleado>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<PaqueteEmpleado>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.PaqueteEmpleados).Returns(mockDbsetPaqueteEmpleado.Object);

            PaqueteEmpleadorepo = new PaqueteEmpleadoRepositorio(mockDB.Object);
        }
        [Test]
        public void ObtenerTodosTest()
        {
            var result = PaqueteEmpleadorepo.ObtenerTodos();
            Assert.AreEqual(3, result.Count());
        }
        [Test]
        public void ObtenerPorIdPaqueteTest()
        {
            var result = PaqueteEmpleadorepo.ObtenerPorIdPaquete(1);
            Assert.AreEqual("Recepcionado", result[0].Estado);
        }
        [Test]
        public void ObtenerPorIdEmpleadoTest()
        {
            var result = PaqueteEmpleadorepo.ObtenerPorIdEmpleado(5);
            Assert.AreEqual("Arribo", result[0].Estado);
        }
    }
}

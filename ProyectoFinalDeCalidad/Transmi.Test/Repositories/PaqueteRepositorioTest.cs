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
    class PaqueteRepositorioTest
    {
        private IQueryable data;
        private PaqueteRepositorio Paqueterepo;
        [SetUp]
        public void Setup()
        {
            data = new List<Paquete>
            {
                new Paquete{ PaqueteId = 1, Contenido = "Sillas", CiudadMeta = "Cajamarca",
                    CiudadOrigen = "Lima", Pagado = true, Peso = 80, PrecioEnvio = 45, DimensionX = 120,
                    DimensionY = 80, DimensionZ = 45},
                new Paquete{ PaqueteId = 2, Contenido = "Equipo de sonido", CiudadMeta = "Cajamarca",
                    CiudadOrigen = "Cuzco", Pagado = true, Peso = 80, PrecioEnvio = 45, DimensionX = 120,
                    DimensionY = 80, DimensionZ = 45}
            }.AsQueryable();
            var mockDbsetPaquete = new Mock<DbSet<Paquete>>();
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Paquete>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.Paquetes).Returns(mockDbsetPaquete.Object);

            Paqueterepo = new PaqueteRepositorio(mockDB.Object);
        }
        [Test]
        public void ObtenerTodosTest()
        {
            var result = Paqueterepo.ObtenerTodos();
            Assert.AreEqual(2, result.Count());
        }
        [Test]
        public void ObtenerPorIdTest()
        {
            var result = Paqueterepo.ObtenerPorId(1);
            Assert.AreEqual("Sillas", result.Contenido);
        }
        [Test]
        public void ObtenerListaPorIdTest()
        {
            var result = Paqueterepo.ObtenerListaPorId(2);
            Assert.AreEqual("Equipo de sonido", result[0].Contenido);
        }
        [Test]
        public void ObtenerUltimo()
        {
            var result = Paqueterepo.ObtenerUltimo();
            Assert.AreEqual(2, result.PaqueteId);
        }
    }
}

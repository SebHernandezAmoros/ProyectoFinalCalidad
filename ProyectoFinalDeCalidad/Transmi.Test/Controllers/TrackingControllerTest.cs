using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.Controllers;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;
using TransportesYComercializaciónTRANSMI.Repositories;

namespace Transmi.Test.Controllers
{
    class TrackingControllerTest
    {
        TrackingController trackingController;

        private IQueryable data;
        private IQueryable data2;
        private IQueryable data3;
        [SetUp]
        public void Setup()
        {
            var mockClienteRepositorio = new Mock<IClienteRepositorio>();
            //var mockEmpleadoRepositorio = new Mock<IEmpleadoRepositorio>();
            var mockPaqueteRepositorio = new Mock<IPaqueteRepositorio>();
            var mockPaqueteEmpleadoRepositorio = new Mock<IPaqueteEmpleadoRepositorio>();
            var mockPaqueteClienteRepositorio = new Mock<IPaqueteClienteRepositorio>();

            //--------------------------------------------------------------------------------------------------
            data = new List<Empleado>
            {
                new Empleado{ EmpleadoId=1, Usuario="User1", Apellido="Hernandez", Dni="45789612",
                 Clave="123450", Nombre="Seb", Direccion="jr calle falsa", Telefono="97568412"},
                new Empleado{EmpleadoId=2, Usuario="User2", Apellido="Hernandez", Dni="45789612",
                 Clave="123450", Nombre="Seb", Direccion="jr calle falsa", Telefono="97568412"}
            }.AsQueryable();
            var mockDbsetEmpleado = new Mock<DbSet<Empleado>>();
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Empleado>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.Empleados).Returns(mockDbsetEmpleado.Object);

            EmpleadoRepositorio Empleadorepo = new EmpleadoRepositorio(mockDB.Object);
            //------------------------------------------------------------------------------------------
            data2 = new List<Paquete>
            {
                new Paquete{ PaqueteId = 1, Contenido = "Sillas", CiudadMeta = "Cajamarca",
                    CiudadOrigen = "Lima", Pagado = true, Peso = 80, PrecioEnvio = 45, DimensionX = 120,
                    DimensionY = 80, DimensionZ = 45},
                new Paquete{ PaqueteId = 2, Contenido = "Equipo de sonido", CiudadMeta = "Cajamarca",
                    CiudadOrigen = "Cuzco", Pagado = true, Peso = 80, PrecioEnvio = 45, DimensionX = 120,
                    DimensionY = 80, DimensionZ = 45}
            }.AsQueryable();
            var mockDbsetPaquete = new Mock<DbSet<Paquete>>();
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.Provider).Returns(data2.Provider);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.Expression).Returns(data2.Expression);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.ElementType).Returns(data2.ElementType);
            mockDbsetPaquete.As<IQueryable<Paquete>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Paquete>)data2.GetEnumerator());
            var mockDB2 = new Mock<DbEntities>();
            mockDB2.Setup(o => o.Paquetes).Returns(mockDbsetPaquete.Object);

            PaqueteRepositorio Paqueterepo = new PaqueteRepositorio(mockDB2.Object);
            //------------------------------------------------------------------------------------------
            data3 = new List<Cliente>
            {
                new Cliente { ClienteId=1, Dni="45783612", Ruc="", Nombre="Seb", Apellido="Hernandez"},
                new Cliente { ClienteId=2, Dni="89564578", Ruc="", Nombre="Francis", Apellido="Paper"}
            }.AsQueryable();
            var mockDbsetCliente = new Mock<DbSet<Cliente>>();
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.Provider).Returns(data3.Provider);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.Expression).Returns(data3.Expression);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.ElementType).Returns(data3.ElementType);
            mockDbsetCliente.As<IQueryable<Cliente>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Cliente>)data3.GetEnumerator());
            var mockDB3 = new Mock<DbEntities>();
            mockDB3.Setup(o => o.Clientes).Returns(mockDbsetCliente.Object);

            ClienteRepositorio Clienterepo = new ClienteRepositorio(mockDB3.Object);
            //-------------------------------------------------------------------------------------------------
            
            trackingController = new TrackingController(Clienterepo, Empleadorepo, Paqueterepo, mockPaqueteClienteRepositorio.Object, mockPaqueteEmpleadoRepositorio.Object);
        }

        [Test]
        public void SearchTrackingCorrecto()
        {
            var view = trackingController.SearchTracking(1) as ViewResult;

            Assert.AreEqual("SearchTracking", view.ViewName);
        }
        [Test]
        public void SearchTrackingIncorrecto()
        {
            var view = trackingController.SearchTracking(100) as ViewResult;

            Assert.AreEqual("Index", view.ViewName);
        }

        [Test]
        public void CreatePackageGet()
        {
            var view = trackingController.CreatePackage();
            Assert.IsNotNull(view);
        }
        [Test]
        public void CreatePackagePostErroneo()
        {
            var result = trackingController.CreatePackage(new Paquete { PaqueteId = 1, Contenido = "Sillas" });

            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void CreatePackagePostCorrecto()
        {
            var result = trackingController.CreatePackage(new Paquete
            {
                PaqueteId = 1,
                Contenido = "Sillas",
                CiudadMeta = "Cajamarca",
                CiudadOrigen = "Lima",
                Pagado = true,
                Peso = 80,
                PrecioEnvio = 45,
                DimensionX = 120,
                DimensionY = 80,
                DimensionZ = 45
            });

            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public void ViewPackages()
        {
            var result = trackingController.ViewPackages(1);
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void UpdatePackageGet()
        {
            var result = trackingController.UpdatePackage(1);
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void UpdatePackagePostCorrecto()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim> { new Claim(ClaimTypes.Name, "User1") });
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);

            trackingController.ControllerContext = new ControllerContext
            {
                HttpContext = mockContext.Object
            };

            var result = trackingController.UpdatePackage(
                new PaqueteEmpleado
                {
                    IdPaquete = 1,
                    Estado = "Partio",
                    CiudadActual = "Lima",
                    FechaActualizacion = DateTime.Now
                });

            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }
        public void UpdatePackagePostErroneo()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim> { new Claim(ClaimTypes.Name, "User1") });
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);
            trackingController.ControllerContext = new ControllerContext
            {
                HttpContext = mockContext.Object
            };
            var result = trackingController.UpdatePackage(
                new PaqueteEmpleado
                {
                    Estado = null,
                    CiudadActual = null,
                });
            Assert.IsInstanceOf<ViewResult>(result);
        }
        [Test]
        public void CreateActorsPost()
        {
            var mockClaimsPrincipal = new Mock<ClaimsPrincipal>();
            mockClaimsPrincipal.Setup(o => o.Claims).Returns(new List<Claim> { new Claim(ClaimTypes.Name, "User1") });
            var mockContext = new Mock<HttpContext>();
            mockContext.Setup(o => o.User).Returns(mockClaimsPrincipal.Object);
            trackingController.ControllerContext = new ControllerContext
            {
                HttpContext = mockContext.Object
            };

            List<Cliente> ListaActores = new List<Cliente> {
                new Cliente { ClienteId=1, Dni="45783612", Ruc="", Nombre="Seb", Apellido="Hernandez"},
                new Cliente { ClienteId=2, Dni="89564578", Ruc="", Nombre="Francis", Apellido="Paper"}
            };

            var result = trackingController.CreateActors(ListaActores);

            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}

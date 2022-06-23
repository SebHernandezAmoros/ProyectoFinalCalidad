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
    class EmpleadoRepositorioTest
    {
        private IQueryable data;
        private EmpleadoRepositorio Empleadorepo;
        [SetUp]
        public void Setup()
        {
            data = new List<Empleado>
            {
                new Empleado{ EmpleadoId=1, Usuario="User1", Apellido="Hernandez", Dni="45789612",
                 Clave="123450", Nombre="Seb", Direccion="jr calle falsa", Telefono="97568412"},
                new Empleado{EmpleadoId=2, Usuario="User2", Apellido="Fernandez", Dni="45789612",
                 Clave="123450", Nombre="Maria", Direccion="jr calle real", Telefono="998554223"}
            }.AsQueryable();
            var mockDbsetEmpleado = new Mock<DbSet<Empleado>>();
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.Provider).Returns(data.Provider);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.Expression).Returns(data.Expression);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.ElementType).Returns(data.ElementType);
            mockDbsetEmpleado.As<IQueryable<Empleado>>().Setup(o => o.GetEnumerator()).Returns((IEnumerator<Empleado>)data.GetEnumerator());
            var mockDB = new Mock<DbEntities>();
            mockDB.Setup(o => o.Empleados).Returns(mockDbsetEmpleado.Object);

            Empleadorepo = new EmpleadoRepositorio(mockDB.Object);

        }
        [Test]
        public void ObtenerTodosTest()
        {
            var result = Empleadorepo.ObtenerTodos();
            Assert.AreEqual(2, result.Count);
        }
        [Test]
        public void ObtenerPorUserNameTest()
        {
            var result = Empleadorepo.ObtenerPorUserName("User1");
            Assert.AreEqual(1, result.EmpleadoId);
        }
        [Test]
        public void ObtenerPorIdTest()
        {
            var result = Empleadorepo.ObtenerPorId(2);
            Assert.AreEqual("Maria", result.Nombre);
        }
    }
}

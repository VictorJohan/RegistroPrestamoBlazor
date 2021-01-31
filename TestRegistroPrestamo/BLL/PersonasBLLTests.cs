using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroPrestamoBlazor.BLL;
using RegistroPrestamoBlazor.DAL;
using RegistroPrestamoBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRegistroPrestamo.DALTest;

namespace RegistroPrestamoBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        private Contexto _contexto;
        private PersonasBLL personasBLL;

        [TestInitialize]
        private void UnitTest()
        {
            _contexto = ContextoTest.GetContexto();
            personasBLL = new PersonasBLL(_contexto);
        }

        [TestMethod()]
        public void PersonasBLLTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public async void GuardarTest()
        {
            bool ok = false;
            Personas personas = new Personas()
            {
                PersonaId = 1,
                Nombres = "Victor Johan",
                Cedula = "111-1111111-1",
                FechaNacimiento = DateTime.Now,
                Direccion = "Av. Caonabo",
                Telefono = "000-000-0000",
                Balance = 0
            };

            ok = await personasBLL.Guardar(personas);
            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public async void ExisteTest()
        {
            bool ok = false;
            ok = await personasBLL.Existe(1);

            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public async void BuscarTest()
        {
            Personas personas;
            bool ok = false;

            personas = await personasBLL.Buscar(1);
            if(personas != null) { ok = true; }

            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public void GetPersonasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPersonasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }
    }
}
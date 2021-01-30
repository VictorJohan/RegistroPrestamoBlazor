using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroPrestamoBlazor.BLL;
using RegistroPrestamoBlazor.DAL;
using RegistroPrestamoBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistroPrestamoBlazor.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void PersonasBLLTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public async void GuardarTest()
        {
            PersonasBLL personasBLL = new PersonasBLL(_contexto);
            Personas personas = new Personas
            {
                PersonaId = 1,
                Nombres = "Victor Johan Palma Rodriguez",
                Cedula = "111-1111111-1",
                Telefono = "809-664-3559",
                FechaNacimiento = DateTime.Now,
                Direccion = "Av. Caonabo",
                Balance = 0
            };


            Assert.IsTrue(await personasBLL.Guardar(personas));
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
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
    }
}
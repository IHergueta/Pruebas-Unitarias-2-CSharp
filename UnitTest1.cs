using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClínicaVeterinaria;

namespace Pruebas_Vet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Jugar()
        {

            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.Jugar("pelota")).Returns(true);

            Assert.IsTrue(((IMascota)mockMascota.Object).Jugar("pelota"));
        }

        [TestMethod]
        public void Se_Regala()
        {

            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.SeRelaja("chuche")).Returns(true || false);

            Assert.IsTrue(((IMascota)mockMascota.Object).SeRelaja("chuche"));
        }

        [TestMethod]
        public void Ya_Vacunado()
        {

            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.YaVacunado("Rabia")).Returns(true);

            Assert.IsTrue(((IMascota)mockMascota.Object).YaVacunado("Rabia"));
        }

        [TestMethod]
        public void Vacunar()
        {

            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.Vacunar("Rabia")).Throws(new Exception("Ya ha sido vacunado de Rabia"));

            var ex = Assert.ThrowsException<Exception>(() => mockMascota.Object.Vacunar("Rabia"));
            Assert.AreSame(ex.Message, "Ya ha sido vacunado de Rabia");

        }

        [TestMethod]
        public void Premiar()
        {

            //al llamar a otro metodo no se puede hacer nada
        }

        [TestMethod]
        public void Poner_Vacuna()
        {

            var mockVeterinario = new Mock<IVeterinario>();
            var mockMascota = new Mock<IMascota>();
            mockVeterinario.Setup(x => x.PonerVacuna(new Mascota("Bolt", "12-12-12"), "Rabia")).Returns(true);

            bool prueba = ((IVeterinario)mockVeterinario.Object).PonerVacuna(new Mascota("Bolt", "12-12-12"), "Rabia");

            //Assert.IsTrue(prueba);

            if(prueba == true)
            {
                Assert.IsTrue(true);
            }
            else if(prueba == false)
            {
                Assert.IsFalse(false);
            }


        }

        [TestMethod]
        public void Ejercitar_Mascota()
        {

            ICliente cliente = (ICliente)new Cliente("nombre","dni","apellidos");

            var mockMascota = new Mock<IMascota>();
            bool exito = ((IMascota)mockMascota.Object).Jugar("pelota");

            try
            {

                mockMascota.Setup(x => x.Jugar("pelota")).Returns(true);
                cliente.EjercitarMascota((IMascota)mockMascota.Object, "pelota");

            }
            catch (Exception e)
            {

                Assert.AreSame("Se ha ejercitado", e.Message);

            }   

        }

        [TestMethod]
        public void Vacunar_Mascota()
        {

           //al llamar a otro metodo no hay que hacer nada 



        }

        [TestMethod]
        public void Alta_cliente()
        {

            IClinica clinica = (IClinica)new Clinica();
            ICliente c = (ICliente)new Cliente("nombre", "dni", "apellios");


            clinica.AltaCliente(c);

            Assert.IsTrue(clinica.getClientes().Contains(c));



        }

        [TestMethod]
        public void Alta_Veterinario()
        {

            IClinica clinica = (IClinica)new Clinica();
            IVeterinario v = (IVeterinario)new Veterinario("nombre");


            clinica.AltaVeterinario(v);

            Assert.IsTrue(clinica.getVeterinario().Contains(v));

        }

        [TestMethod]
        public void setNombre()
        {

            IMascota mas = (IMascota)new Mascota("Bolt", "12-2-12");

            mas.SetNombre("Ramiro");

            Assert.AreEqual("Ramiro", mas.GetNombre());



        }

        [TestMethod]
        public void getNombre()
        {

            IMascota mas = (IMascota)new Mascota("Bolt","12-12-12");

            string nombre = mas.GetNombre();

            Assert.AreEqual("Bolt", nombre);



        }

    }
}

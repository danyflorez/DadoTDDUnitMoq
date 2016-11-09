using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetasCreditoWeb.Tests
{
    [TestFixture]
    class JuegoAzarTest
    {
        [Test]
        public void cuandoElDadoSea5DebeRetornarGanaste() {
            //arrange
            var dadoMoq = new Mock<Dado>();
            dadoMoq.Setup(i => i.lanzarDado()).Returns(5);
            JuegoAzar juegoAzar = new JuegoAzar(dadoMoq.Object);
            //act
            var resultado = juegoAzar.jugar();
            //assert
            Assert.AreEqual("Ganaste!!", resultado);
        }
    }
}

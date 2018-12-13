using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MisOfertasFinal.LogicaNegocio;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOfertas()
        {
            var ofertas = new LnOferta().GetListadoOfertas();
            Assert.IsNotNull(ofertas);
        }
    }
}

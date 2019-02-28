using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, test);

        }
    }
}

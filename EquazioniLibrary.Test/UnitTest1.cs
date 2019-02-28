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
        [TestMethod]
        public void TestMethod2()
        {
            double a = 0, b=3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.IsInconsisted(a,b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 0, b = 0;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
    }
}

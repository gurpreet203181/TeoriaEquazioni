using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Determinato1()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Determinato(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Determinato2()
        {
            double a = 2;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Determinato(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Determinato3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Determinato(a);

            Assert.AreEqual(risposta_attesa, test);

        }



        [TestMethod]
        public void Impossible1()
        {
            double a = 0, b = 3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Impossible(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossible2()
        {
            double a = 3, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossible(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossible()
        {
            double a = 0, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossible(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Impossible4()
        {
            double a = 3, b = 3;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Impossible(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }




        [TestMethod]
        public void Indeterminato1()
        {
            double a = 0, b = 0;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Indeterminato(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void Indeterminato2()
        {
            double a = 2, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminato(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Indeterminato3()
        {
            double a = 0, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminato(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Indeterminato4()
        {
            double a = 2, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Indeterminato(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }





        [TestMethod]
        public void Controlo1()
        {
            double a = 3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Controlo(a);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void Controlo2()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Controlo(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Controlo3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Controlo(a);

            Assert.AreEqual(risposta_attesa, test);

        }






        [TestMethod]
        public void Delta1()
        {
            double a = 0, b = 5, c = 2;
            double risposta_attesa = 25;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta2()
        {
            double a = 2, b = 0, c = 2;
            double risposta_attesa = -16;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta3()
        {
            double a = 2, b = 4, c = 0;
            double risposta_attesa = 16;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void Delta4()
        {
            double a = 0, b = 0, c = 0;
            double risposta_attesa = 0;
            double test = EquazioniLibrary.Equazioni.Delta(a, b, c);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione1()
        {
            double a = 0, b = 0;
            string risposta_attesa = "Indeterminato";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione2()
        {
            double a = 0, b = 3;
            string risposta_attesa = "Impossibile";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void Equazione3()
        {
            double a = 1, b = 3;

            string risposta_attesa = $"x={-3}";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]

        public void Equazione4()
        {
            double a = 1, b = -3;

            string risposta_attesa = $"x={3}";
            string test = EquazioniLibrary.Equazioni.Equazione(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }




    }
}

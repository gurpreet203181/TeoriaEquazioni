using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDetermined1()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void IsDetermined2()
        {
            double a = 2;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void IsDetermined3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, test);

        }



        [TestMethod]
        public void IsInconsisted()
        {
            double a = 0, b=3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.IsInconsisted(a,b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void IsInconsisted2()
        {
            double a = 3, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void IsInconsisted3()
        {
            double a = 0, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void IsInconsisted4()
        {
            double a = 3, b = 3;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }




        [TestMethod]
        public void indeterminata1()
        {
            double a = 0, b = 0;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void indeterminata2()
        {
            double a = 2, b = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void indeterminata3()
        {
            double a = 0, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void indeterminata4()
        {
            double a = 2, b = 2;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.indeterminata(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }





        [TestMethod]
        public void grado1()
        {
            double a = 3;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Isdegree2(a);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]
        public void grado2()
        {
            double a = 0;
            bool risposta_attesa = false;
            bool test = EquazioniLibrary.Equazioni.Isdegree2(a);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]
        public void grado3()
        {
            double a = -1;
            bool risposta_attesa = true;
            bool test = EquazioniLibrary.Equazioni.Isdegree2(a);

            Assert.AreEqual(risposta_attesa, test);

        }



        


        [TestMethod]
        public void Delta1()
        {
            double a = 0, b = 5, c=2 ; 
           double risposta_attesa = 25;
            double test = EquazioniLibrary.Equazioni.Delta(a,b,c);

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

        public void EquationDegree1()
        {
            double a = 0, b = 0;
            string risposta_attesa = "Indeterminato";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void EquationDegree2()
        {
            double a = 0, b = 3;
            string risposta_attesa = "Impossibile";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }
        [TestMethod]

        public void EquationDegree3()
        {
            double a = 1, b = 3;
          
            string risposta_attesa = $"x={-3}";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a, b);

            Assert.AreEqual(risposta_attesa, test);

        }

        [TestMethod]

        public void EquationDegree4()
        {
            double a = 1, b = -3;
           
            string risposta_attesa = $"x={3}";
            string test = EquazioniLibrary.Equazioni.EquationDegree(a  , b);

            Assert.AreEqual(risposta_attesa, test);

        }
       

        

    }
}

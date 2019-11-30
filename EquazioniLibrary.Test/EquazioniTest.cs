using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public static void IsDeterminata()
        {
            double a = 4;
            double b = 5;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void IsIncosisted()
        {
            double a = 0;
            double b = 5;
            bool risposta_aspettata = true;
            bool risposta1 = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta1);
        }
        [TestMethod]
        public static void IsDegree2()
        {
            double a = 0;
            bool risposta_aspettata = true;
            bool risposta2 = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta2);
        }
        [TestMethod]
        public static void Delta()
        {
            double a = 4;
            double b = 8;
            double c = 6;
            double risposta_aspettata = -32;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void Delta1()
        {
            double a = 2;
            double b = 8;
            double c = 6;
            double risposta_aspettata = -32;
            double risposta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void EquationDegree1()
        {
            double a = 4;
            double b = 12;
            double risposta_aspettata = -3;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);

        }
        [TestMethod]
        public static void EquationDegree1_1()
        {
            double a = 0;
            double b = 0;
             string risposta_aspettata = "indeterminata";
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);

        }
        [TestMethod]
        public static void EquationDegree1_2()
        {
            double a = 7;
            double b = 0;
            string risposta_aspettata = "impossibile";
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);

        }
        [TestMethod]
        public static void EquationDegree1_3()
        {
            double a = -4;
            double b = 2;
            double risposta_aspettata = 2;
            string risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);

        }
    }
}

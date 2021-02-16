using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void TestIsDeterminedTrue()
        {
            double a = 4;
            bool valore_aspettato = true;
            bool prova = Equazioni.IsDetermined(a);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsDeterminedFalse()
        {
            double a = 0;
            bool valore_aspettato = false;
            bool prova = Equazioni.IsDetermined(a);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsInconsistedTrue()
        {
            double a = 0;
            double b = 6;
            bool valore_aspettato = true;
            bool prova = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsInconsistedFalse()
        {
            double a = 5;
            double b = 6;
            bool valore_aspettato = false;
            bool prova = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, prova);
        }
    }
}

using szyfr_konsola;

namespace testy_jednostkowe
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Test1_DanePodstawowe()
        {
            string wynik = Program.szyfrujTekst("abc", 3);
            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void Test2_Zawijanie()
        {
            string wynik = Program.szyfrujTekst("xyz", 3);
            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void Test3_KluczUjemny()
        {
            string wynik = Program.szyfrujTekst("def", -3);
            Assert.AreEqual("abc", wynik);
        }

        [TestMethod]
        public void Test4_KluczWiekszyNiz26()
        {
            string wynik = Program.szyfrujTekst("abc", 29);
            Assert.AreEqual("def", wynik);
        }

        [TestMethod]
        public void Test5_SpacjeWTekscie()
        {
            string wynik = Program.szyfrujTekst("ab cd", 2);
            Assert.AreEqual("cd ef", wynik);
        }
    }
}

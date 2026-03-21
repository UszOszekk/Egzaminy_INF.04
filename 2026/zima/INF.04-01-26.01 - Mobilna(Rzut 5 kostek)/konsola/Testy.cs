using kosci_konsola;

namespace testy_jednostkowe
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void czyWZakresie()
        {
            Kosc kosc = new Kosc();

            kosc.rzucKoscia();

            Assert.IsTrue(kosc.liczbaOczek >= 1 && kosc.liczbaOczek <= 6, "Wyrzucona wartosc nie miesci sie w zakresie 1-6");
        }

        [TestMethod]
        public void gdyZablokowana()
        {
            Kosc kosc = new Kosc(3);
            kosc.blokujKosc();
            int poprzedniaWartosc = kosc.liczbaOczek;

            kosc.rzucKoscia();

            Assert.AreEqual(poprzedniaWartosc, kosc.liczbaOczek, "Wartosc zmienila sie mimo zablokowania");
        }
    }
}

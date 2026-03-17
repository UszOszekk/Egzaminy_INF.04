using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_konsolowa
{
    class Film
    {
        protected string tytulFilmu;
        protected int liczbaWypo;
        public Film()
        {
            tytulFilmu = "";
            liczbaWypo = 0;
        }
        public void setTytul(string tytul)
        {
            tytulFilmu = tytul;
        }
        public string getTytul()
        {
            return tytulFilmu;
        }
        public int getLiczbaWypo()
        {
            return liczbaWypo;
        }
        public void inkrementujWypo()
        {
            liczbaWypo++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();

            Console.WriteLine($"Tytuł: {film.getTytul()}");
            Console.WriteLine($"Liczba wypozyczen: {film.getLiczbaWypo()}");

            film.setTytul("film1");
            Console.WriteLine($"Tytuł: {film.getTytul()}");

            film.inkrementujWypo();
            Console.WriteLine($"Liczba wypozyczen: {film.getLiczbaWypo()}");
        }
    }
}

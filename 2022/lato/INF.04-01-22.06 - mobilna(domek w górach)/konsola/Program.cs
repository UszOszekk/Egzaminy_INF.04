using System;

internal class Program
{
    /****************************************************** 
    Nazwa funkcji: Wyszukaj 
    argumenty: 
    tab: przechowuje tablice przynajmniej 50 liczb od 1 do 100
    szukana: podana przez użytkownika liczba, której szukamy w tablicy
    typ zwracany: int - zwracany jest indeks, na którym została znaleziona liczba szukana w tablicy tab
    informacje: Za pomocą wyszukiwania z wartownikiem znajdujemy szukaną liczbę w tablicy i zwracamy jej indeks
    Autor: 000000000000000
    *****************************************************/
    static int Wyszukaj(int[] tab, int szukana)
    {
        int wartownik = szukana;
        tab[tab.Length - 1] = wartownik;
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] == szukana){

                return i;
            }
        }
        return -1;
    }
    static void Wypelnij(int[] tab)
    {
        Random R = new Random();
        for (int i = 0; i < tab.Length - 1; i++)
        {
            tab[i] = R.Next(1, 101);
        }
    }
    static void Wypisz(int[] tab)
    {
        for (int i = 0; i < 51; i++)
        {
            Console.WriteLine("Indeks: " + i + " Liczba: " + tab[i] + ", ");
        }
    }


    private static void Main(string[] args)
    {

        int[] tab = new int[51];
        Wypelnij(tab);
        Console.WriteLine("Podaj liczbe, ktora chcesz znalezc w tablicy (1 - 100)");
        int PodanaPrzezUzytkownika = int.Parse(Console.ReadLine());
        if (Wyszukaj(tab, PodanaPrzezUzytkownika) == tab.Length - 1)
        {
            Console.WriteLine("Nie znaleziono liczby ");

        }
        else
        {
            Console.WriteLine("Znaleziono na indeksie: " + Wyszukaj(tab, PodanaPrzezUzytkownika));
        }
        Wypisz(tab);

    }
}
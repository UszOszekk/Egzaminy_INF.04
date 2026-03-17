
namespace INF._04_02_24._06_SG
{

    public class metodyNapisowe
    {
        class Album{
            public string artysta = "";
            public string album = "";
            public int liczbaPiosenek = 0;
            public int rok = 0;
            public int liczbaPobran = 0;
        
            
        }

        static string[] wczytajPlik(string nazwaPliku) {
            string[] linie = File.ReadAllLines(nazwaPliku);
            return linie;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                
               string[] plik = wczytajPlik("./Data.txt");

               for (int i = 0; i < plik.Length; i++)
               {
                   Console.WriteLine(plik[i]);
               }
                List<Album> tablicaAlbumów = new List<Album>();
               for(int i = 0; i < plik.Length; i++)
                {


                    Album album = new Album();
                    album.artysta = plik[i];
                    i++;
                    album.album = plik[i];
                    i++;
                    album.liczbaPiosenek = int.Parse(plik[i]);
                    i++;
                    album.rok = int.Parse(plik[i]);
                    i++;
                    album.liczbaPobran = int.Parse(plik[i]);
                    i++;
                    tablicaAlbumów.Add(album);
                    
                    

               }

                foreach (var item in tablicaAlbumów)
                {
                    Console.WriteLine($"{item.artysta}\n{item.album}\n{item.liczbaPiosenek}\n{item.rok}\n{item.liczbaPobran}\n");
                }





            }
        }
    }
}

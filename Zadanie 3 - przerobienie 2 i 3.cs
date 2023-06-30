using System;
using Internal;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj rozmiar tablicy:");
        int rozmiar;
        bool poprawnyRozmiar = int.TryParse(Console.ReadLine(), out rozmiar);

        if (poprawnyRozmiar && rozmiar > 0)
        {
            int[,] tablica = new int[rozmiar, rozmiar];
            int liczba = 1;

           
            for (int wiersz = 0; wiersz < rozmiar; wiersz++)
            {
                for (int kolumna = 0; kolumna < rozmiar; kolumna++)
                {
                    tablica[wiersz, kolumna] = liczba;
                    liczba++;
                }
            }

           
            for (int wiersz = 0; wiersz < rozmiar; wiersz++)
            {
                for (int kolumna = 0; kolumna < rozmiar; kolumna++)
                {
                    Console.Write(tablica[wiersz, kolumna] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Niepoprawny rozmiar tablicy");
        }
    }
}

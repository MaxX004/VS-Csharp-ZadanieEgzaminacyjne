using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IEnumerable;
using System.Collections;

namespace MSzymaniec
{

    internal class Program
    {
        public class Tablica
        {

            private int[] T = new int[10];
            Random rand = new Random();
            public void Inicjuj()
            {

                for(int i=0;i<10;i++)
                {                   
                    T[i] = rand.Next(10)+1;
                }
            }
            public void Wypisz()
            {
                for (int i= 0;i < 10;i++)
                {
                    Console.WriteLine(T[i]);
                }
            }
            public void Sortuj()
            {
                int licznik = 0;
                int y=1;
                for (int x = 0; x < y-1; x++) 
                { 
                    if (T[x] < T[y])

                }
            }
            public void MinMaks()
            {
                //2.Posortować
                //3. Znaleźć Min i Maks za pomocą algorytmu naiwnego 
                /*4.Wejściowy zbiór(tablicę) dzielimy na dwa podzbiory w następujący sposób: porównujemy
                 parami liczby - pierwszą z drugą, trzecią z czwartą itd.. Liczby mniejsze zapisujemy w 
                jednym podzbiorze, a większe w drugim. W pierwszym podzbiorze korzystając z tradycyjnego algorytmu
                na znalezienie minimum znajdujemy element najmniejszy. 
                W drugim podzbiorze korzystając z tradycyjnego algorytmu na znalezienie maksimum
                znajdujemy element największy.*/
                
            }
        }

        static void Main(string[] args)
        {
            Tablica tablica = new Tablica();
            tablica.Inicjuj();
            tablica.Wypisz();
            tablica.MinMaks();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IEnumerable;
using System.Collections;
using System.Net.Mail;

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
                Console.WriteLine();
            }
            public void Sortuj()
            {
                int x=0;
                int licznikX=x;
                int tempx = 0;
                int tempy = 0;
                int n=T.Length;
                int orderCounter = 0;
                while (orderCounter<=10)
                {
                    try
                    {
                        if (T[x] > T[x + 1])

                        {
                            tempx = T[x];
                            tempy = T[x + 1];
                            T[x] = tempy;
                            T[x + 1] = tempx;
                            x++;
                            orderCounter = 0;
                        }


                        else if (T[x] < T[x + 1])
                        {
                            x++;
                            orderCounter++;
                        }
                        else if (T[x] == T[x+1])
                        {
                            x++;
                        }
                     
                    }
                    catch (System.IndexOutOfRangeException) { x = 0; }
                    if (x>n-1)
                    {
                        x = 0;
                    }
                }
            }
            public void MinMaks()
            {
                int lowest=T[0];
                int highest=0;
                int changeCount=0;
                int i = 0;
                while (changeCount < 10)
                {
                    if (T[i] < lowest)
                    {
                        lowest = T[i];
                        i=0;
                        changeCount = 0;
                    }
                    else
                    {
                        changeCount++;
                        i++;
                    }
                }
                Console.WriteLine("Najniższa liczba: "+lowest);
                Console.WriteLine();
                i = 0;
                changeCount=0;
                while (changeCount < 10)
                {
                    if (T[i] > highest)
                    {
                        highest = T[i];
                        i = 0;
                        changeCount = 0;
                    }
                    else
                    {
                        changeCount++;
                        i++;
                    }
                }
                Console.WriteLine("Najwyższa liczba: "+highest);
                Console.WriteLine();
                int tempS;
                int tempH;
                int[] Ts = new int[5];
                int[] Th = new int[5];
                i = 0;
                for (int x=0; x < 10;)
                {
                    try
                    {
                        if (T[x] > T[x + 1])
                        {
                            tempH = T[x];
                            tempS = T[x + 1];
                            Th[i] = tempH;
                            Ts[i] = tempS;
                        }
                        else if (T[x] < T[x + 1])
                        {
                            tempS = T[x];
                            tempH = T[x + 1];
                            Th[i] = tempH;
                            Ts[i] = tempS;
                        }
                        else
                        {
                            tempH = T[x];
                            tempS = T[x + 1];
                            Th[i] = tempH;
                            Ts[i] = tempS;
                        }
                        x = x+2;
                        i++;
                    }
                    catch (Exception e) { break; }
                }
                Console.WriteLine("Większe liczby z porównanych par");
                foreach (int x in Th)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("Mniejsze liczby z porównanych par");
                foreach (int x in Ts)
                {
                    Console.WriteLine(x);
                }
                //for()
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
            Console.WriteLine("Początkowa tablica");
            tablica.Inicjuj();
            tablica.Wypisz();

            Console.WriteLine("Posortowana tablica");
            tablica.Sortuj();
            tablica.Wypisz();
            tablica.MinMaks();
            
            Console.ReadKey();
        }
    }
}

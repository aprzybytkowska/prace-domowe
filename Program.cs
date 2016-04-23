using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz program:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Porownanie");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                 Triangle();
                    break;

                case 2:
                    Console.WriteLine("Podaj liczbę a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj liczbę b: ");
                    int b = int.Parse(Console.ReadLine());

                    int zwrot = Porownanie(a,b);
                    Console.WriteLine("Wynik porównania: " + zwrot);
                    break;
                   
        }
           


        }
        static void Triangle ()
        {
            Console.WriteLine("Witaj w programie do obliczania czy odcinki mogą stać się trójkątem!!");
            Console.WriteLine("Podaj długość odcinka 1: ");
            double part1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość odcinka 2: ");
            double part2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość odcinka 3: ");
            double part3 = double.Parse(Console.ReadLine());


            if ((part1 + part2 > part3) && (part2 + part3 > part1) && (part1 + part3 > part2))
            {
                Console.WriteLine("Mogą!");
            }
            else
            {
                Console.WriteLine(" Nope. ");
            }
        }

        static int Porownanie(int a, int b)
        {
            
            
            if (a > b)
            {

                return 1;
            }
            else if (b == a)
            {
                 return 0;
            }
            else
            {
                
                return -1;
            }
        }


    }
}

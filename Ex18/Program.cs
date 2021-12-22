using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să citească două numere reale a şi b. Apoi să pună utilizatorului o 
            //întrebare: Ce doriţi să calculăm ? Media aritmetică(1) sau geometrică(2)?. Dacă se va
            //răspunde prin 1, se va calcula şi afişa media aritmetică, iar pentru 2 media geometrică(numai
            //dacă numerele sunt pozitive !, iar de nu, se va afişa ‘eroare!’). Dacă nu se răspunde prin 1
            //sau 2 se va produce un sunet în difuzor.

            Console.WriteLine("Introduceti valoarea lui a:");
            var a = CRead.NextDouble();
            Console.WriteLine("Introduceti valoarea lui b:");
            var b = CRead.NextDouble();

            Console.WriteLine("Alegeti ce doriti sa calculati: Media aritmetica (1) sau media geometrica (2)?");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }

            switch (input)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine($"Media aritmetica a lui {a} si {b}: {(a + b) / 2}");
                    ClickToContinue();
                    break;
                case "2":
                    Console.WriteLine();
                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("eroare!");
                        ClickToContinue();
                        return;
                    }
                    Console.WriteLine($"Media geometrica a lui {a} si {b}: {Math.Pow(a * b, 0.5)}");
                    ClickToContinue();
                    return;
                default:
                    Console.Beep();
                    ClickToContinue();
                    return;
            }
    }
}

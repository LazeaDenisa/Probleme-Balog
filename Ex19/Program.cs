using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de 
            //genul: Ce doriţi să calculăm? Aria sau perimetrul?.Dacă se va răspunde prin ‘aria’ atunci se
            //va calcula şi afişa aria, altfel perimetrul.

            Console.WriteLine("Introduceti valoarea lui a:");
            var a = CRead.NextUnsignedDouble();

            Console.WriteLine("Introduceti valoarea lui b:");
            var b = CRead.NextUnsignedDouble();

            Console.WriteLine("Introduceti valoarea lui c:");
            var c = CRead.NextUnsignedDouble();

            if (!NumbersHelper.CanBeTriangle(a, b, c))
            {
                Console.WriteLine();
                Console.WriteLine("Cele trei valori nu pot forma un triunghi.");
                ClickToContinue();
                return;
            }

            Console.WriteLine("Ce doriti sa calculam? Aria sau permietrul?");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }

            var perimeter = a + b + c;

            while (true)
            {
                switch (input.ToLower())
                {
                    case "aria":
                    case "arie":
                        var area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b) * (perimeter / 2 - c));
                        Console.WriteLine();
                        Console.WriteLine($"Aria este: {area}.");
                        ClickToContinue();
                        return;
                    case "perimetru":
                    case "permietrul":
                        Console.WriteLine();
                        Console.WriteLine($"Perimetrul este: {perimeter}");
                        ClickToContinue();
                        return;
                    default:
                        Console.WriteLine("Selecteaza un raspuns valid: aria sau perimetrul.");
                        break;

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două
            //numere întregi a şi b.

            Console.WriteLine("Introduceti o valoare pentru a:  ");
            var a = CRead.NextInt();
            Console.WriteLine("Introduceti o valoare pentru b: ");
            var b = CRead.NextInt();

            Console.WriteLine();
            Console.WriteLine($"Cel mai mare divizor comun a lui {a} si {b} este {NumbersHelper.GreatestCommonDivisor(a, b)}, " + $"iar cel mai mic multiplu comun este {NumbersHelper.LeastCommonMultiple(a, b)}");
        }
    }
}

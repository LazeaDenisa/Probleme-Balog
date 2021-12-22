using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieţi un program care să calculeze factorialul unui număr întreg n.

            Console.WriteLine("Introduceti valoarea lui n:");
            var n = CRead.NextNaturalNumber();

            Console.WriteLine();
            Console.WriteLine($"{n}! = {MathHelper.Factorial(n)}");
        }
    }
}

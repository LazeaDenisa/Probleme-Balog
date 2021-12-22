using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fie i,j,k. Să se determine restul împărţirii numărului natural ij la k.

            Console.WriteLine("Introduceti o valoare pentru i: ");
            var i = CRead.NextNaturalNumber();
            Console.WriteLine("Introduceti o valoare pentru j: ");
            var j = CRead.NextNaturalNumber();
            Console.WriteLine("Introduceti o valoare pentru k: ");
            var k = CRead.NextInt();

            Console.WriteLine();
            Console.WriteLine("{0}^{1} / {2}{3}{4} = {5}",
                i,
                j,
                k < 0 ? "(" : "",
                k,
                k < 0 ? ")" : "",
                Math.Pow(i, j) / k
                );
            ClickToContinue();
        }
    }
}

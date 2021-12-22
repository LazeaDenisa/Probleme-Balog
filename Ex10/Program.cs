using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se afişeze primele n numere prime.

            int n, i, j, prim;

            Console.WriteLine("Introduceti un numar pentru n: ");
            n = int.Parse(Console.ReadLine());
            i = 1;

            while(n != 0)
            {
                i++;
                prim = 1;

                for (j = 2; j <= i / 2; j++)

                    if (i % j == 0)

                        prim = 0;

                if (prim == 1)

            }
                
        }
    }
}

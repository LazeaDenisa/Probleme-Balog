using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma divizorilor lui diferiţi de n; exemplu: 6 = 1 + 2 + 3)

            int n;
            int i;
            int suma = 0;

            Console.Write("Introduceti un numar pentru n:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    suma = suma + i;
                }
            }

            if (n == suma)
            {
                Console.WriteLine($"Numarul {n} este perfect");
            }

            else
            {
                Console.WriteLine($"Numarul {n} nu este perfect");
            }

            Console.ReadLine();
        }
    }
}

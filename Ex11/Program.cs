using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se determine dacă două numere sunt prime între ele sau nu.

            int a;
            int b;
            int r;

            Console.WriteLine("Introduceti un numar pentru a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar pentru b: ");
            b = int.Parse(Console.ReadLine());

            r = a % b;

            while (a * b != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            if (y == 1)
            {
                Console.WriteLine("Numerele sunt prime intre ele");
            }
            else
            {
                Console.WriteLine("Numerele nu sunt prime intre ele");
            }
        }
    }
}

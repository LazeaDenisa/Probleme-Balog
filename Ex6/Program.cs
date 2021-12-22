using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Două numere întregi x şi y sunt "prietene" dacă suma divizorilor numărului x este egală cu
            //suma divizorilor numărului y. Să se găsească numerele "prietene" din intervalul[a, b]

            Console.WriteLine("Introduceti un numar pentru x: ");
            var x = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti un numar pentru y: ");
            var y = CRead.NextNaturalNumber();

            Console.WriteLine();
            Console.WriteLine(NumbersHelper.AreFriends(x, y)
                ? $"{x} si {y} sunt prietene."
                : $"{x} si {y} nu sunt prietene.");
        }
    }
}

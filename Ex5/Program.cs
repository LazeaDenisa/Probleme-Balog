using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se determine numerele perfecte din intervalul [a,b], pentru a,b date.

            Console.WriteLine("Introduceti valoarea lui a:");
            var a = CRead.NextNaturalNumber();

            Console.WriteLine("Introduceti valoarea lui b:");
            var b = CRead.NextNaturalNumber();

            if (a > b)
            {
                (a, b) = (b, a);
            }

            var builder = new StringBuilder($"Numerele perfecte din intervalul [{a}, {b}]: ");
            var count = 0;
            for (var i = a; i <= b; i++)
            {
                if (!NumbersHelper.IsPerfect(i))
                {
                    continue;
                }

                count++;
                builder.Append($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine(count == 0
              ? $"In intervalul [{a}, {b}] nu exista numere perfecte."
              : builder.ToString());
        }

    }

}

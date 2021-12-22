using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            //O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?

            Console.WriteLine("Introduceti numarul de foi: ");
            var n = CRead.NextPositiveInt();

            Console.WriteLine("Introduceti numarul de randuri / foaie: ");
            var r = CRead.NextPositiveInt();

            long total = n * r;
            Console.WriteLine();
            Console.WriteLine($"Cartea cu {n} pagini si {r} randuri per pagina are {total} randuri in total.");
        }
    }
}

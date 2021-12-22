using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fie n,k. Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte k.

            Console.WriteLine("Introduceti o valoare lui n: ");
            var n = CRead.NextUnsignedShort();
            Console.WriteLine("Introduceti o valoare lui k: ");
            var k = CRead.NextUnsignedShort();

            Console.WriteLine();
            Console.WriteLine($"Combinari de {n} luate cate {k} = {MathHelper.Choose(n, k)}");

        }
    }
}

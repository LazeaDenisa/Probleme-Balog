using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fie a. Să se scrie un algoritm pentru calculul mediei aritmetice, geometrice şi armonice a
            // tuturor divizorilor lui a.

            Console.WriteLine("Introduceti o valoare lui a: ");
            var a = CRead.NextNaturalNumber();

            var divisors = NumbersHelper.GetDivisors(a);
            divisors.Add(a);

            var arithmetic = divisors.Sum() / divisors.Count;
            var geometric = Math.Pow(divisors.Aggregate(1L, (current, divisor) => current * divisor), 1.0 / divisors.Count);
            var harmonic = (float)divisors.Count / divisors.Aggregate(0.0, (current, divisor) => current + 1.0 / divisor);

            Console.WriteLine();
            Console.WriteLine($"Media aritmetica: {arithmetic}, media geometrica: {geometric}, media armonica: {harmonic}.");
         
        }
    }
    }
}

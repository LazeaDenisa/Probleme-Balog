using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0. Să se calculeze media 
            //aritmetică a numerelor din şir.

            Console.WriteLine("Introduceti secventa de numere cate unul pe fiecare linie:");
            var list = new List<int>();

            while (true)
            {
                var newNumber = CRead.NextInt();

                if (newNumber == 0)
                {
                    break;
                }

                list.Add(newNumber);
            }

            if (list.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Media aritmetica este 0.");
                ClickToContinue();
                return;
            }
        }
    }
}

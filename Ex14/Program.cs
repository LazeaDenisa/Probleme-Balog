using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, şi să 
            //determine cel mai mic număr şi cel mai mare număr citit.


            Console.WriteLine("Introduceti secventa de numere cate unul: ");
            var newNumber = CRead.NextInt();

            var min = newNumber;
            var max = newNumber;

            if (newNumber == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Cel mai mic numar: {min}, iar cel mai mare numar: {max}.");
                ClickToContinue();
                return;
            }

            while (true)
            {
                newNumber = CRead.NextInt();

                if (newNumber < min)
                {
                    min = newNumber;
                }

                if (newNumber > max)
                {
                    max = newNumber;
                }

                if (newNumber == 0)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Cel mai mic numar: {min}, iar cel mai mare numar: {max}.");
        }
    }
    }
}

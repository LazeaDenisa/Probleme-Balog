using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elaboraţi un program care să tipărească tabela de temperaturi Fahrenheit şi echivalenţele lor 
            //în centigrade sau grade Celsius, folosind formula: C = (5 / 9) * (F - 32), între valorile extreme 0 şi
            //300 grade Fahrenheit.

            Console.WriteLine("Fahrenheit | Celsius");
            for (var i = 0; i <= 300; i++)
            {
                Console.WriteLine("{0} | {1:f4}", i, 5.0 / 9.0 * (i - 32.0));
            }

        }
    }
}

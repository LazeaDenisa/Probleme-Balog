using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch

            Console.WriteLine("Introduceti o temperatura: ");
            var initTemp = CRead.NextDouble();

            Console.WriteLine("Din ce scala va fi convertita temperatura? Alegeti raspunsul: C/Celsius sau F/Fahrenheit.)");
            while (true)
            {

                     var input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))

                    {
                            continue;
                    }

                switch (input.ToLower())
                {


                    case "c":
                    case "celsius":
                        Console.WriteLine();
                        Console.WriteLine($"{initTemp}°C in Fahrenheit: {initTemp * 9 / 5 + 32}");
                        ClickToContinue();
                        return;
                    case "f":
                    case "fahrenheit":
                        Console.WriteLine();
                        Console.WriteLine($"{initTemp}°F in Celsius: {(initTemp - 32) * 5 / 9}");
                        ClickToContinue();
                        return;
                    default:
                        Console.WriteLine("Alege un raspuns: C/Celsius sau F/Fahrenheit.");
                        break;



                }
            }
        }
    }
}
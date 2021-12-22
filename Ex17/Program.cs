using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un punct material se află la distanţa x0 de origine, la momentul iniţial t0, când începe să se 
            //mişte rectiliniu uniform.Çtiind că la momentul t se află la distanţa x faţă de origine, să se
            //determine viteza v de mişcare a punctului material, la momentul t

            Console.WriteLine("Introduceti valoarea x0: ");
            var x0 = CRead.NextUnsignedDouble(); 

            Console.WriteLine("Introduceti valoarea t0: ");
            var t0 = CRead.NextUnsignedDouble();

            Console.WriteLine("Introduceti valoarea t: ");
            var t = CRead.NextUnsignedDouble();

            Console.WriteLine("Introduceti valoarea x: ");
            var x = CRead.NextUnsignedDouble();

            var distance = x - x0;
            var time = t - t0;

            if (distance < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Distanta parcursa nu poate fi negativa.");
                return;
            }

            if (time <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Durata nu poate fi mai mica sau egala cu 0.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(distance == 0
                ? "Punctul material nu se misca."
                : $"Viteza de miscare a punctului este {distance / time}");
        }
    }
}

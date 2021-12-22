﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elaboraţi un program care să tipărească tabela corespunzătoare Celsius-Fahrenheit.

            Console.WriteLine("Celsius | Fahrenheit");
            for (var i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0} | {1:f1}", i, i * (9.0 / 5.0) + 32.0);
            }
        }
    }
}

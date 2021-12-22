using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică:
            //adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
            //selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să
            //ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii,
            //înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.

            Console.WriteLine("Care este operatia pe care vrei sa o executi? Alege din urmatoarele variante: (+ sau adunare), (- sau scadere), (* sau inmultire), " + "(/ sau impartire), (sqrt sau radical), (| sau modul).");
           
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                double first;
                double second;
                switch (input.ToLower())
                {
                    case "adunare":
                    case "+":
                        Console.WriteLine("Introduceti 2 numere pe care doriti sa le adunati: ");
                        first = CRead.NextDouble();
                        second = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine("{0} + {1}{2}{3} = {4}",
                            first,
                            second < 0 ? "(" : "",
                            second,
                            second < 0 ? ")" : "",
                            first + second
                            );
                        ClickToContinue();
                        return;
                   
                    
                    case "scadere":
                    case "-":
                        Console.WriteLine("Introduceti 2 numere pe care doriti sa le scadeti: ");
                        first = CRead.NextDouble();
                        second = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine("{0} - {1}{2}{3} = {4}",
                            first,
                            second < 0 ? "(" : "",
                            second,
                            second < 0 ? ")" : "",
                            first - second
                            );
                        ClickToContinue();
                        return;
                  
                    
                    case "inmultire":
                    case "*":
                        Console.WriteLine("Introduceti 2 numere pe care doriti sa le inmultiti:");
                        first = CRead.NextDouble();
                        second = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine("{0} * {1}{2}{3} = {4}",
                            first,
                            second < 0 ? "(" : "",
                            second,
                            second < 0 ? ")" : "",
                            first * second
                            );
                        ClickToContinue();
                        return;
                   
                    
                    case "impartire":
                    case "/":
                        Console.WriteLine("Introduceti 2 numere pe care doriti sa le impartiti:");
                        first = CRead.NextDouble();
                        second = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine("{0} / {1}{2}{3} = {4}",
                            first,
                            second < 0 ? "(" : "",
                            second,
                            second < 0 ? ")" : "",
                            first / second
                            );
                        ClickToContinue();
                        return;
                   
                    
                    case "radical":
                    case "sqrt":
                        Console.WriteLine("Introduceti numarul al carui radical doriti sa il calculati:");
                        var square = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine(square >= 0
                            ? $"√{square} = {Math.Sqrt(square)}"
                            : $"√{square} = {Math.Sqrt(square)} * i");
                        ClickToContinue();
                        return;
                   
                    
                    case "modul":
                    case "|":
                        Console.WriteLine("Introduceti numarul al carui modul doriti sa il calculati:");
                        var number = CRead.NextDouble();

                        Console.WriteLine();
                        Console.WriteLine($"|{number}| = {Math.Abs(number)}");
                        ClickToContinue();
                        return;
                    default:
                        Console.WriteLine("Selecteaza un raspuns: (+ sau adunare), (- sau scadere), (* sau inmultire), " + "(/ sau impartire), (sqrt sau radical), (| sau modul).");
                        break;

                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will prfloat ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            float a = 23;
            float b = 124;
            float c = a + b;
            Console.WriteLine(c);
            float num1 = 0; float num2 = 0;
            // Afisearea ttitlului aplicatiei in C# Calculator
            Console.WriteLine("Aplicatia Calculator!\r");
            Console.WriteLine("#-----------------------------\n");

            Console.WriteLine("floatroduceti un numar si apasati tasta Enter: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("floatroduceti un alt numar si apasati tasta Enter: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Alegeti o optiune din lista urmatoare : ");
            Console.WriteLine("\ta - Adunare ");
            Console.WriteLine("\ts - Scadere ");
            Console.WriteLine("\ti - Inmultire ");
            Console.WriteLine("\tj - Impartire ");
            Console.Write("floatroduceti alegerea dvs. : ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Resultat: {num1} + {num2} = " + (num1+num2));
                    break;
                case "s":
                    Console.WriteLine($"Rezultat: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "i":
                    Console.WriteLine($"Rezultat: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "j":
                    Console.WriteLine($"Rezultat: {num1} / {num2} = " + (num1 / num2));
                    break;

            }

            Console.WriteLine("Apasati orice tasta pentru a inchide aplicatia:");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

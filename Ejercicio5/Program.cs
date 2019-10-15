using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("ingrese la altura de la piramide:");
            c = int.Parse(Console.ReadLine());
            for (a = 1; a <= c; a++)
            {
                for (b = 1; b <= c - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}


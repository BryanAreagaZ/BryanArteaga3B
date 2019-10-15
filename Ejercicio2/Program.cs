using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el numero del tamaño del cuadrado");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= 50)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" *");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(" *");
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" *");
                }
            }

            Console.ReadKey();
        }
    }
}

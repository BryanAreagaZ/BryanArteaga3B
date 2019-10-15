using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla, var1 = 1, T = 0;
            Console.Write("digite el numero de la tabla:");
            tabla = int.Parse(Console.ReadLine());
            for (var1 = 1; var1 <= 15; var1++)
            {
                T = var1 * tabla;
                Console.WriteLine(+tabla + "x" + var1 + "=" + T);
            }

            Console.ReadKey();
        }
    }
}


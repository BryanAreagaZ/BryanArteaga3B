using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            double P, S = 0, T;
            Console.WriteLine("precione 0 en la cantidad para finalizar");
            do
            {
                Console.Write("introdusca la cantidad vendida: ");
                cant = int.Parse(Console.ReadLine());

                if (cant > 0)
                {
                    Console.Write("ingrese el precio del producto: ");
                    P = double.Parse(Console.ReadLine());
                    T = cant * P;
                    S = S + T;

                }
                else
                if (cant < 0)
                {
                    Console.WriteLine(" el numeor es negativo");
                }

            } while (cant != 0);

            Console.Write("la cantidad total es: " + S);
            Console.ReadKey();

        }
    }
}

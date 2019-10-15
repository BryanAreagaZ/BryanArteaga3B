using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant, num, mayor = 0;
            Console.WriteLine("La cantidad de numeros que desea ingresar :");
            cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.Write("Escriba el numero ");
                num = int.Parse(Console.ReadLine());
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
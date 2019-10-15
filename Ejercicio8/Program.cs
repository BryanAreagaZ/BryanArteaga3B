using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Columna1 = 0, Columna2 = 0, Columna3 = 0, Num;
            Console.Write("ingrese el numero:");
            Num = int.Parse(Console.ReadLine());
            if (Num > 0)
            {
                while (Columna1 < Num)
                {
                    Columna1++;
                    if (Columna1 <= Num)
                    {
                        Console.Write("Columna1=  " + Columna1 + "   ");
                    }
                    Columna2 = Columna2 + 2;
                    if (Columna2 <= Num)
                    {
                        Console.Write("columna2=  " + Columna2 + "   ");
                    }
                    Columna3 = Columna3 + 3;
                    if (Columna3 <= Num)
                    {
                        Console.Write("columna3=  " + Columna3 + "   ");
                    }
                    Console.WriteLine(" ");
                }


            }
            Console.ReadKey();
        }

    }
}


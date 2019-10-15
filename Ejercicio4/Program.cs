using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Time, otro, TimeEx, Total = 525;
            double Salario‬, SalarioEx;
            do
            {
                Console.Write("Ingrese las horas trabajadas por los empleados :");

                Time = int.Parse(Console.ReadLine());
                if (Time <= 35)
                {
                    Salario = Time * 15;
                }
                else
                {
                    TimeEx = Time - 35;
                    SalarioEx = TimeEx * 22;
                    Salario = SalarioEx + Total;

                }
                Console.WriteLine("El salario total de los empleados es: " + Salario);
                Console.WriteLine("Si desea ingresar otro salaio precione 1 caso contrario preione 0 :");
                otro = int.Parse(Console.ReadLine());
            }
            while (otro == 1);

            Console.WriteLine("El programa se ha cerrado Exitosamente");
            Console.ReadLine();



        }
    }
}

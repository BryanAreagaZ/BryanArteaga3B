using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec = 0;
            do
            {
                Console.WriteLine("Elija una de las siguientes opciones:" +
                    "\n1.-Salir" +
                    "\n2.-Sumatorio" +
                    "\n3.-Factorial");
                selec = int.Parse(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        selec = 1;
                        Console.WriteLine("El programa se cerro con exito");
                        break;
                    case 2:
                        selec = 2;
                        int num1 = 0, num2 = 0, Resul = 0;
                        Console.WriteLine("Ingrese el primer nuemro:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el psegundo nuemro:");
                        num2 = int.Parse(Console.ReadLine());
                        Resul = num1 + num2;
                        Console.WriteLine(num1 + "+" + num2 + "=" + Resul);

                        break;
                    case 3:
                        selec = 3;
                        int numero = 0;
                        double fac = 1;
                        Console.WriteLine("Ingrese un numero:");
                        numero = int.Parse(Console.ReadLine());
                        int numero1 = numero;
                        while (numero != 0)
                        {
                            fac = fac * numero;
                            numero--;
                        }
                        Console.WriteLine("El factorial de" + numero1 + "=" + fac);
                        break;
                }

                Console.Write("\n");
            } while (selec != 1);
            Console.ReadKey();
        }
    }
}
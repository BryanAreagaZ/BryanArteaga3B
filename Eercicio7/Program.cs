using System;

namespace Eercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 101;
            while (A < 100)
            {
                A = A + 1;
                B = B - 1;
                Console.WriteLine(+A + "  " + B);
            }
            Console.ReadKey();
        }

    }
}


using System;
using Ventas_de_Gasolina.Clases;

namespace Ventas_de_Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Cliente comprador = new Cliente("Bryan", "Arteaga", "1316490034", "los geranios,Manta");
            DatosGasolina Tgasolina = new DatosGasolina("sueper", 5);
            Console.WriteLine("=========Tercer  Nivel  Cía.  Ltd==========");
            Console.WriteLine("==================Factura==================");
            Console.WriteLine("=========Informacion del comprador=========");
            Console.Write("Nombre: ");
            comprador.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            comprador.Apellido = Console.ReadLine();
            Console.Write("Numero de cedula: ");
            comprador.Ceduladeidentidad = Console.ReadLine();
            Console.Write("Direccion: ");
            comprador.Direccion = Console.ReadLine();
            Console.WriteLine("==========Informacion de la venta========");
            Console.Write("Que tipo de gasolina solicita:\nextra \nsuper\n");
            Tgasolina.Tipo = Console.ReadLine();
            Console.Write("Que cantidad desea: ");
            Tgasolina.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("precio: " + Tgasolina.Precio);
            Console.WriteLine("Subtotal: " + Tgasolina.Subtotal());
            Console.WriteLine("Iva: " + Tgasolina.Iva());
            Console.WriteLine("Total: " + Tgasolina.Total());
            Console.ReadKey();

        }
    }
}
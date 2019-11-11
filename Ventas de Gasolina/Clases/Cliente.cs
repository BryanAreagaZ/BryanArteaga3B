using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas_de_Gasolina.Clases
{
    public class Cliente
    {
        private string nombre;

        public Cliente(string nombre, string apellido, string cédulaDeIdentidad, string céduladeidentidad, string direccion) : this(nombre, apellido, cédulaDeIdentidad, céduladeidentidad)
        {
            Direccion = direccion;
        }

        public Cliente(string nombre, string apellido, string céduladeidentidad, string dirección)
        {
            Nombre = nombre;
            Apellido = apellido;
            Ceduladeidentidad = céduladeidentidad;
            Direccion = direccion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }
        private string cedulaDeIdentidad;
        public string Ceduladeidentidad
        {
            get { return cedulaDeIdentidad; }
            set { cedulaDeIdentidad = value; }
        }
        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Ventas_de_Gasolina.Clases
{
    public class DatosGasolina
    {
        private String tipo;

        public DatosGasolina(string tipo, int cantidad)
        {
            Tipo = tipo;
            Cantidad = cantidad;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private float precio;

        public float Precio
        {
            get
            {
                if (tipo == "extra")
                {
                    precio = 1.5f;
                    return precio;
                }
                else
                {
                    if (tipo == "super")

                        precio = 2f;
                    return precio;
                }
            }
        }
        public float Subtotal()
        {
            return Precio * Cantidad;
        }
        public float Iva()
        {
            return Subtotal() * 0.12f;
        }
        public float Total()
        {
            return Iva() + Subtotal();
        }
    }
}
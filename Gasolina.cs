using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo3.Clases
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantidadDeGalones;

        public int CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }


        double precioDeVenta;

        public double PrecioDeVenta
        {
            get
            {
                if (this.tipo == "Extra")
                {
                    return 1.50;
                }
                else
                {
                    return 2;
                }
            }

        }

        double subtotal;

        public double Subtotal
        {
            get {
                return CantidadDeGalones * PrecioDeVenta;
            }
        }



        double iva;

        public double IVA
        {
            get
            {
                return Subtotal * 0.12;
            }
        }

        double  total;

        public double Total
        {
            get
            {
                return Subtotal+IVA;
            }
        }

    }
}


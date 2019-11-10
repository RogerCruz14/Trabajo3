using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo3.Clases
{
    class Cliente
    {
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string numeroCD;

        public string NumeroCD
        {
            get { return numeroCD; }
            set { numeroCD = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


    }
}

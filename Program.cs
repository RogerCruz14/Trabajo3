using System;
using System.Collections.Generic;
using Trabajo3.Clases;

namespace Trabajo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Gasolina gasolina = new Gasolina();
            Console.WriteLine("     Descripción");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese sus Apellidos:");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su Nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Numero de Cedula:");
            cliente.NumeroCD = Console.ReadLine();
            Console.WriteLine("Ingrese su Direccion:");
            cliente.Direccion = Console.ReadLine();

            Console.WriteLine("\n El precio por galon es de: " +
                "Extra es de $1.50 " +
                "Super es de $2.00\n");
            Console.WriteLine("Tipo de Gasolina Extra o Super:");
            String tipo = Console.ReadLine();
            gasolina.Tipo = tipo;
         
            Console.WriteLine("Cuantos Galones desea:");
            int cantidadDeGalones = int.Parse(Console.ReadLine());
            gasolina.CantidadDeGalones =cantidadDeGalones;

            Console.WriteLine("\n");
            Console.WriteLine("El subtotal es:"+ gasolina.Subtotal);
            Console.WriteLine("IVA:" + gasolina.IVA);
            Console.WriteLine("Total a Pagar es:" + gasolina.Total);
            Console.WriteLine("\n");
            Console.WriteLine("!GRACIAS POR SU COMPRA :D¡");
            Console.ReadKey();
        }
    }
}
